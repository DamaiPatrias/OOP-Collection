using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Colletion.KelasInduk;

namespace OOP_Colletion.KelasAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double upahperjam { get; set; }
        public double jumlahjamkerja { get; set; }
        public override double Gaji()
        { 
            return upahperjam*jumlahjamkerja;
        }
    }
}
