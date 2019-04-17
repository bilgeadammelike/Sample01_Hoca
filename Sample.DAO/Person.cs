using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DAO
{
    public class Person : Object
    {
        public string NameSurName { get; set; }
        public string Age { get; set; }
        public string Bolum
        {
            get
            {
                return "YAZILIM";
            }
        }
        public override string ToString()
        {
            return string.Format("Adınız: {0} yaşınız: {1}", NameSurName, Age);
        }
    }
}
