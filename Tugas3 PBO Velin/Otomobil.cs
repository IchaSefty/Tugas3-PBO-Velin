using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_PBO_Velin
{
    class Otomobil
    {
        public string model;
        public string warna;
    }
    class Sedan : Otomobil
    {
        public void setSedan(string model, string warna)
        {
            this.model = model;
            this.warna = warna; 
        }
        public (string, string) getSedan()
        {
            return (model, warna);
        }
    }
}
