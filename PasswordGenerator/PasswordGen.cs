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
        System.Security.Cryptography.RandomNumberGenerator secureRand;

        /*
         * Strength 0-2 : 0 weak, 1 moderate, 2 strong
         * Security 0-1 : 0 insecure, 1 secure
         * */
        public Password GeneratePassword(int strength, int length, int security)
        {
            Password pass;
            PasswordChecker check = new PasswordChecker();
            switch (strength)
            {
                //Weak
                case 0:
                    pass = new Password(GenerateWeakPasswordString(length, security));
                    check.CalculatePasswordStrength(ref pass);
                    return pass;
                //Moderate
                case 1:
                    pass = new Password(GenerateModeratePasswordString(length, security));
                    check.CalculatePasswordStrength(ref pass);
                    return pass;
            }
            //Strong
            pass = new Password(GenerateStrongPasswordString(length, security));
            check.CalculatePasswordStrength(ref pass);
            return pass;
        }

        public string GenerateWeakPasswordString(int length, int security)
        {
            string password = "";
            if (length < 12)
                length = 12;
            while (password.Length < length)
            {
                if(security == 0)
                {
                    password += GetNextCharacter(0);
                }
                else
                {
                    password += GetNextCharacterSecure(0);
                }
            }

            return password;
        }

        public string GenerateModeratePasswordString(int length, int security)
        {
            string password = "";
            if (length < 12)
                length = 12;
            while (password.Length < length)
            {
                if (security == 0)
                {
                    password += GetNextCharacter(1);
                }
                else
                {
                    password += GetNextCharacterSecure(1);
                }
            }
            return password;
        }

        public string GenerateStrongPasswordString(int length, int security)
        {
            string password = "";
            if (length < 12)
                length = 12;
            while (password.Length < length)
            {
                if (security == 0)
                {
                    password += GetNextCharacter(2);
                }
                else
                {
                    password += GetNextCharacterSecure(2);
                }
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

        private char GetNextCharacterSecure(int strength)
        {
            int randomChar;
            char nextChar = 'a';

            switch (strength)
            {
                //Weak characters between a - z (97 - 122)
                case 0:
                    randomChar = SecureRandomInt(97, 123);
                    nextChar = (char)randomChar;
                    break;
                //Moderate characters between a-z (97-122) and A-Z (65-90)
                case 1:
                    int upperLower = rand.Next(1, 3);
                    if (upperLower == 1)
                    {
                        randomChar = SecureRandomInt(97, 123);
                        nextChar = (char)randomChar;
                        break;
                    }
                    randomChar = SecureRandomInt(65, 91);
                    nextChar = (char)randomChar;
                    break;
                //Strong characters between a-z (97-122), A-Z (65-90), 0-9 (48-57), !-/ (33-47), :-@ (58-64) and [-` (91-96)
                case 2:
                    randomChar = SecureRandomInt(33, 123);
                    nextChar = (char)randomChar;
                    break;
            }
            return nextChar;
        }

        private int SecureRandomInt(int min, int max)
        {
            secureRand = System.Security.Cryptography.RandomNumberGenerator.Create();

            //Store bytes of an integer
            byte[] bytes = new byte[4];
            //Generate bytes through the cryptographically secure RNG
            secureRand.GetBytes(bytes);

            //Convert the bytes we got to UInt32
            UInt32 scale = BitConverter.ToUInt32(bytes, 0);

            secureRand.Dispose();
            //Calculate the number between min and max inclusive
            return (int)(min + (max - min) * (scale / (uint.MaxValue + 1.0)));
        }
    }
}
