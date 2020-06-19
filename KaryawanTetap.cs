using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Colletion.KelasInduk;

namespace OOP_Colletion.KelasAnak
{
    public class KaryawanTetap : Karyawan
    {  
        public double gajibulanan { get; set; }
        public override double Gaji()
        {
            return gajibulanan;
        }
    }
}
