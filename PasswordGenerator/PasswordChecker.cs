using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PasswordGenerator
{
    class PasswordChecker
    {
        public void PrintPasswordStrength(Password pass)
        {
            CalculatePasswordStrength(ref pass);


        }


        public void CalculatePasswordStrength(ref Password pass)
        {
            pass.config.goodLength           = LongerThanTwelve(pass);
            pass.config.hasLowerCase         = HasLowerCase(pass);
            pass.config.hasUpperCase         = HasUpperCase(pass);
            pass.config.hasNumber            = HasNumber(pass);
            pass.config.hasExtraCharacters   = HasExtra(pass);
            pass.config.isUnique             = IsUnique(pass);

            //Calculating password Entropy
            pass.entropicValue = calculatePasswordEntropy(pass);

            if(pass.entropicValue < 50)
            {
                pass.strength = "weak";
            } else if(pass.entropicValue < 75)
            {
                pass.strength = "moderate";
            }
            else
            {
                pass.strength = "strong";
            }

            Console.WriteLine(pass.strength);
        }

        private double calculatePasswordEntropy(Password pass)
        {
            double passwordEntropy = 0;
            int possibleCharacters = calculatePossibleCharacters(pass);

            double possiblePasswords = Math.Pow(possibleCharacters, pass.password.Length);

            passwordEntropy = Math.Log(possiblePasswords, 2);

            return passwordEntropy;
        }

        private int calculatePossibleCharacters(Password pass)
        {
            int possibleCharacters = 0;
            if (pass.config.hasLowerCase)
            {
                possibleCharacters += 25;
            }
            if (pass.config.hasUpperCase)
            {
                possibleCharacters += 25;
            }
            if (pass.config.hasNumber)
            {
                possibleCharacters += 10;
            }
            if (pass.config.hasExtraCharacters)
            {
                possibleCharacters += 32;
            }

            return possibleCharacters;
        }

        private Boolean LongerThanTwelve(Password pass)
        {
            return pass.password.Length > 12;
        }

        private Boolean HasLowerCase(Password pass)
        {
            string password = pass.password;
            Char[] passwordArray = password.ToCharArray();
            for(int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(passwordArray[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean HasUpperCase(Password pass)
        {
            string password = pass.password;
            Char[] passwordArray = password.ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(passwordArray[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean HasNumber(Password pass)
        {
            string password = pass.password;
            Char[] passwordArray = password.ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(passwordArray[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean HasExtra(Password pass)
        {
            //33-47, 58-64, 91-96, 123-126
            string password = pass.password;
            Char[] passwordArray = password.ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                int unicode = (int)passwordArray[i];
                if ((unicode >= 33 && unicode <= 47) || (unicode >= 58 && unicode <= 64) || (unicode >= 91 && unicode <= 96) || (unicode >= 123 && unicode <= 126))
                {
                    return true;
                }
            }

            return false;
        }

        //List of common passwords retrieved from https://github.com/danielmiessler/SecLists/blob/master/Passwords/Common-Credentials/10k-most-common.txt
        private Boolean IsUnique(Password pass)
        {
            string password = pass.password;
            string currentLine = String.Empty;
            string list = Properties.Resources.CommonPasswords;
            StringReader stringReader = new StringReader(list);
            do
            {
                currentLine = stringReader.ReadLine();
                if (currentLine != null)
                {
                    if (currentLine == password)
                    {
                        return false;
                    }
                }
            } while (currentLine != null);

            return true;
        }
    }
}
