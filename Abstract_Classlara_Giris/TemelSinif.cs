using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlara_Giris
{
    public abstract class TemelSinif
    {
        public void metot1()
        {
            Console.WriteLine("Metot1 çalişti"); // metotun bodysi
        }

        public abstract void metot2(); // metotun imzası denir
        // eğer metotun body si olmiycaksa abstract anahtar kelimesini erişim belirleyicisinden sonra ekledik




    }
}
