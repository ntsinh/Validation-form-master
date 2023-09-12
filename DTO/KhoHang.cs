using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoHang
    {
        public string maKhoXuat { get; set; }
        public  string tenKhoXuat { get; set; }
        public string moTa { get; set; }

        public KhoHang()
        {
            
        }

        public KhoHang(string maKhoXuat, string tenKhoXuat, string moTa)
        {
            this.maKhoXuat = maKhoXuat;
            this.tenKhoXuat = tenKhoXuat;
            this.moTa = moTa;
        }
    }
}
