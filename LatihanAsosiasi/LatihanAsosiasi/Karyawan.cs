using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public bool Status { get; set; }
        
        public bool Login (Kartu kartu)
        {
            return kartu.IsValid(this);
        }
    }
}
