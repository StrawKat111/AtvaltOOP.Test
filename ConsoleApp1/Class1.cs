using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class AtvaltOOP
    {
        public class Atvalt
        {
            private int eredmeny;


            public Atvalt()
            {
                eredmeny = 0;
            }


            public void SetSzam(int szam)
            {
                eredmeny = szam;
            }


            public void Atvalto()
            {

                if (IsBinary(eredmeny.ToString()))
                {
                    eredmeny = Convert.ToInt32(eredmeny.ToString(), 2);
                }
                else
                {

                    eredmeny = Convert.ToInt32(eredmeny.ToString(), 2);
                }
            }

            public int GetEredmeny()
            {
                return eredmeny;
            }

            private bool IsBinary(string input)
            {
                foreach (char c in input)
                {
                    if (c != '0' && c != '1')
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
