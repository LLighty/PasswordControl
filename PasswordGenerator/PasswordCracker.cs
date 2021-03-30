using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PasswordCracker
    {
        const int millisecondsInMinute = 60000;
        //int minutesToRunBruteForce = 1;

        public Boolean BruteForceSimple(Password pass, double minutesToRunBruteForce)
        {
            bool passFound = false;
            var watch = new System.Diagnostics.Stopwatch();
            string password = pass.password;

            watch.Start();

            Console.WriteLine("Begin cracking");
            passFound = GenerateWordsLowerCaseCheck(pass, (minutesToRunBruteForce * millisecondsInMinute));

            if (passFound)
            {
                watch.Stop();
                Console.WriteLine("Brute force took {0} to find the password.", watch.ElapsedMilliseconds);
                return true;
            }

            Console.WriteLine("Brute force could not be completed within {0} minutes.", minutesToRunBruteForce);
            return false;
        }

        //This is simple to extend to more than lowercase (unicode characters for passwords begin at 33 and end at 126)
        //Extending this makes passwords much longer to generate as each character takes that number for each permutation i.e. 25 lowercase = 25^n where n=length
        //If you also include uppercase this becomes 50 (25 lowercase + 25 uppercase) = 50^n ... Etc.
        private Boolean GenerateWordsLowerCaseCheck(Password pass, double timeToRun)
        {
            String password = pass.password;

            String word = "a";
            char[] array;
            int charStart = 97;
            int charEnd = 122;
            int currentIndex = 0;
            int pivotIndex = 0;

            int currentChar;
            int pivotChar;

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            if (word == password)
            {
                Console.WriteLine("Password is a");
                return true;
            }

            while (word.Length < int.MaxValue)
            {
                if(watch.ElapsedMilliseconds > timeToRun){
                    return false;
                }
                currentIndex = word.Length - 1;
                array = word.ToCharArray();

                currentChar = (int)array[currentIndex];
                currentChar++;
                if (currentChar > charEnd)
                {
                    pivotIndex = currentIndex;
                    while (true)
                    {
                        if (currentIndex == 0)
                        {
                            array = IncreaseCharArrayByOne(array);
                            break;
                        }

                        pivotIndex--;
                        pivotChar = (int)array[pivotIndex];
                        pivotChar++;
                        if (pivotChar > charEnd)
                        {
                            if (pivotIndex == 0)
                            {
                                array[pivotIndex] = (char)charStart;
                                array = IncreaseCharArrayByOne(array);
                                break;
                            }
                            else
                            {
                                array[pivotIndex] = (char)charStart;
                            }
                        }
                        else
                        {
                            array[pivotIndex] = (char)pivotChar;
                            break;
                        }

                    }
                    array[currentIndex] = (char)charStart;
                }
                else
                {
                    array[currentIndex] = (char)currentChar;
                }

                word = new string(array);
                if (word == password)
                {
                    return true;
                }
                //System.Threading.Thread.Sleep(100);
            }
            return false;
        }

        static char[] IncreaseCharArrayByOne(char[] arr)
        {
            char[] newArray = new char[arr.Length + 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }

            newArray[newArray.Length - 1] = 'a';

            return newArray;
        }

        public Boolean CheckFromExternalList(Password pass, string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Could not find password list to parse");
                return false;
            }
            string password = pass.password;
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (line == password)
                {
                    return true;
                }
            }

            return false;
        }
        
        public Boolean CheckFromInternalList(Password pass, int listno)
        {
            string password = pass.password;
            switch (listno)
            {
                //CommonPasswords
                case 0:
                    string currentLine = String.Empty;
                    string list = Properties.Resources.CommonPasswords;
                    StringReader stringReader = new StringReader(list);
                    do
                    {
                        currentLine = stringReader.ReadLine();
                        if (currentLine != null)
                        {
                            if(currentLine == password)
                            {
                                return true;
                            }
                        }
                    } while (currentLine != null);
                    break;
            }



            return false;
        }
    }
}
