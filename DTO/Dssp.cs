using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dssp
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public string TinhTrang { get; set; }
        public Dssp()
        {

        }

        public Dssp(string maSp, string tenSp, int soLuong, string moTa, string tinhTrang)
        {
            MaSp = maSp;
            TenSp = tenSp;
            SoLuong = soLuong;
            MoTa = moTa;
            TinhTrang = tinhTrang;
        }
    }
}
