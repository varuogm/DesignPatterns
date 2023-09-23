﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCheck
{
    public class Samosa
    {

        private Samosa()
        {

        }
        public static Samosa _samosa;
        public static Samosa BanaLeyEkObject()
        {

            if (_samosa == null)
            {
                _samosa = new Samosa();
            }

            return _samosa;
        }

        public string GetSamosaChutney(string typeOfChutney)
        {

            return $"{typeOfChutney} chutney";
        }

    }
}
