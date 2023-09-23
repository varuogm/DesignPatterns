using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCheck
{
    public class Jalebi
    {
        public static Jalebi _jalebi = new Jalebi();
        public static Jalebi BanaLeyEkObject()
        {
            return _jalebi;
        }

        public string GetJalebiChaasni(string typeOfChaasni)
        {
            return $"{typeOfChaasni} Chaashni";
        }

    }
}
