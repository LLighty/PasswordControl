using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PasswordForm());
            //PasswordChecker passwordChecker = new PasswordChecker();
            //PasswordGen passwordGen = new PasswordGen();
            //PasswordCracker passwordCracker = new PasswordCracker();

            //Console.WriteLine();

            //Password simplePass = new Password("1");
            //Boolean canCrackBF = passwordCracker.BruteForceSimple(simplePass);


            //Password onList = new Password("turtle");
            //Boolean canCrackList = passwordCracker.CheckFromInternalList(onList, 0);
            //Console.WriteLine("Can crack list: {0}", canCrackList);
            
            //Boolean canCrackList = passwordCracker.CheckFromList(onList, pathCommonPasswords);
            //Console.WriteLine("Can crack list: {0}", canCrackList);
        }

    }
}
