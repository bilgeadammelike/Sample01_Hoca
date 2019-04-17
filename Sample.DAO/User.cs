using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DAO
{
  public  class User
    {
        public string TC { get; set; }


        private string _KullaniciAdi;
        public string KullaniciAdi
        {
            get {
                return _KullaniciAdi;
            }
            set {
                _KullaniciAdi = value;
                _KullaniciAdi = _KullaniciAdi.ToUpper();
               // throw new NotImplementedException();
            }
        }



        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public bool Cinsiyet { get; set; }
    }
}
