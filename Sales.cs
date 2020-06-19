using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Colletion.KelasInduk;

namespace OOP_Colletion.KelasAnak
{ 
    public class Sales : Karyawan
    {  
        public double jumlahpenjualan { get; set; }
        public double komisi { get; set; }
        public override double Gaji()
        {
            return jumlahpenjualan * komisi;
        }
    }
}
