using System;
using System.Collections.Generic;
using System.Text;

namespace ZarOyunu
{
    class HileliZar
    {
        int minZar;
      
        public HileliZar(int minZarCons)
        {
            minZar = minZarCons;
        }
        public int ZarAt()
        {
            return minZar;
        }
   
    }

}
