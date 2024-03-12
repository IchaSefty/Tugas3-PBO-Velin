using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_PBO_Velin
{
    class Truk : Otomobil
    {
        public void setTruk(string model, string warna)
        {
            this.model = model;
            this.warna = warna; 
        }
        public (string, string) getTruk()
        {
            return (model, warna);
        }
    }
}
