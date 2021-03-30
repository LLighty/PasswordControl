using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PasswordGen
    {
        //rand.next(int minValue, int maxValue) max value is EXCLUSIVE.
        Random rand = new Random();


        public Password GeneratePassword(int strength, int length)
        {
            Password pass;
            PasswordChecker check = new PasswordChecker();
            switch (strength)
            {
                //Weak
                case 0:
                    pass = new Password(GenerateWeakPasswordString(length));
                    check.CalculatePasswordStrength(ref pass);
                    return pass;
                //Moderate
                case 1:
                    pass = new Password(GenerateModeratePasswordString(length));
                    check.CalculatePasswordStrength(ref pass);
                    return pass;
            }
            //Strong
            pass = new Password(GenerateStrongPasswordString(length));
            check.CalculatePasswordStrength(ref pass);
            return pass;
        }

        public string GenerateWeakPasswordString(int length)
        {
            string password = "";
            if (length < 12)
                length = 12;
            while (password.Length < length)
            {
                password += GetNextCharacter(0);
            }

            return password;
        }

        public string GenerateModeratePasswordString(int length)
        {
            string password = "";
            if (length < 12)
                length = 12;
            while (password.Length < length)
            {
                password += GetNextCharacter(1);
            }
            return password;
        }

        public string GenerateStrongPasswordString(int length)
        {
            string password = "";
            if (length < 12)
                length = 12;
            while (password.Length < length)
            {
                password += GetNextCharacter(2);
            }
            return password;
        }

        private char GetNextCharacter(int strength)
        {
            int randomChar;
            char nextChar = 'a';

            switch (strength)
            {
                //Weak characters between a - z (97 - 122)
                case 0:
                    randomChar = rand.Next(97, 123);
                    nextChar = (char)randomChar;
                    break;
                //Moderate characters between a-z (97-122) and A-Z (65-90)
                case 1:     
                    int upperLower = rand.Next(1, 3);
                    if (upperLower == 1)
                    {
                        randomChar = rand.Next(97, 123);
                        nextChar = (char)randomChar;
                        break;
                    }
                    randomChar = rand.Next(65, 91);
                    nextChar = (char)randomChar;
                    break;
                //Strong characters between a-z (97-122), A-Z (65-90), 0-9 (48-57), !-/ (33-47), :-@ (58-64) and [-` (91-96)
                case 2:
                    randomChar = rand.Next(33, 123);
                    nextChar = (char)randomChar;
                    break;
            }

            return nextChar;
        }
    }
}
