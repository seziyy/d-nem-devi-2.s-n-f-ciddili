using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dönem_ödevi_2.sınıf_ciddili
{
    public abstract class GenelBilgi
    {
        /*
         GenelBilgi=Ad,Tel 
        
         */
        public string Ad { get; set; }
        public int Tel { get; set; }


        public GenelBilgi() { }

        public abstract string VeriGetir();

        public virtual string veri()
        {
            return "sanal fonksiyon";
        }
    }
}

