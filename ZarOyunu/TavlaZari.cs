using System;
using System.Collections.Generic;
using System.Text;

namespace ZarOyunu
{
    class TavlaZari
    {   /// <summary>
        ///Zarın alabileceği maximum değer değişkeni 
        /// </summary>
        int maxZarDegeri;                                       //Bu bir field


        Random random = new Random();


        /// <summary>
        /// Zarın alabileceği maximum değeri giriniz
        /// </summary>
        /// <param name="maxZarDegeri"></param>
        public TavlaZari(int maxZarDegeri)
        {
            //thisle başlayan satır class için olan değişken, diğeri constructordan gelen değişken.
            this.maxZarDegeri = maxZarDegeri;                   //Bu bir constructor
        }

        public int ZarAt()
        {
            //Rastgele sayı üretilecek
            return random.Next(0, maxZarDegeri + 1);             //Bu bir method
        }
    }
}
