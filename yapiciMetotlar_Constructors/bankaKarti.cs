using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapiciMetotlar_Constructors
{
    class bankaKarti
    {
        private string kartNo;
        private double bakiye;
        private double kullanilanKredi;

        //Constructor  - Yapıcı metot
        //geri dönüş türü olmaz
        //metot adı ait olduğu sınıf adı ile aynı olamalıdır
        //Tanımlanan isim (bakiye ve kartno) aynı isimle kullanılmak istenirse başına this. koyularak kullanılır.
        //this. kullanılmazsa baş harfi büyük kullanılabilir.
        public bankaKarti(double Bakiye, string kartNo)
        {
            this.kartNo = kartNo;
            bakiye = Bakiye;
        }

    }
}
