using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlara_Giris
{
    public class AltSinif :TemelSinif
    {
        public override void metot2() // abstract olarak tanımlanan metotu override ettim
        {
            Console.WriteLine("Metot2 çalıştı");
        }
    }
}
