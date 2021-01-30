using System;
using System.Collections.Generic;
using System.Text;

namespace ZarOyunu
{
    class TavlaZari2
    {
       /// <summary>
       /// Zarın alabileceği maksimum değer değişkeni
       /// </summary>
        int maxZarDegeri;

        Random random = new Random();

        /// <summary>
        /// Zarın alabileceği max değeri girin
        /// </summary>
        /// <param name="maxZarDegeri"></param>
        public TavlaZari2(int maxZarDegeri)
        {
            this.maxZarDegeri = maxZarDegeri;
        }

        public int ZarAt()
        {
            return random.Next(0, maxZarDegeri++);

        }
    }

}
