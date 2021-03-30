using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public struct Password
    {
        public string password;
        public string strength;
        public PasswordConfiguration config;
        public double entropicValue;


        public Password(string pass)
        {
            password = pass;
            strength = null;
            config = new PasswordConfiguration();
            entropicValue = 0;
        }

        public Password(string pass, string strength, PasswordConfiguration passwordConfiguration, double eval)
        {
            password = pass;
            this.strength = strength;
            config = passwordConfiguration;
            entropicValue = eval;
        }
    }

    public struct PasswordConfiguration
    {
        //Note this class could be done with bit set operations and storing each of these booleans in a single uint value i.e. 0b_0000_0000 with each bit holding a value associated with configuration settings.

        public Boolean goodLength;
        public Boolean hasLowerCase;
        public Boolean hasUpperCase;
        public Boolean hasNumber;
        public Boolean hasExtraCharacters;
        public Boolean isUnique;
    }
}
