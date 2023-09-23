using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCheck
{
    public class Samosa
    {
        private Samosa() { }
        public static Samosa _samosa;


        public string ChutneyTaste { get; set; }

        private static readonly object Instancelock = new object();

        public static Samosa BanaLeyEkObject( string taste)
        {
            if (_samosa == null)
            {
                lock (Instancelock)
                {

                    if (_samosa == null)
                    {
                        _samosa = new Samosa();
                        _samosa.ChutneyTaste = taste;
                    }

            }

        }

            return _samosa;
        }

        //public string GetSamosaChutney(string typeOfChutney)
        //{

        //    return $"{typeOfChutney} chutney";
        //}

    }
}
