using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_PBO_Velin
{
    class SepedaMotor : Otomobil
    {
        public void setSepedaMotor(string model, string warna)
        {
            this.model = model;
            this.warna = warna;
        }
        public (string, string) getSepedaMotor()
        {
            return (model, warna);
        }
    }
}
