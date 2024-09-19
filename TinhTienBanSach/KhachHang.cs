using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienBanSach
{
    public class KhachHang
    {
        const double GiaBasic = 20000;
        public string Name { get; set; }
        public int SoLuongMua { get; set; }
        public bool IsSinhVien { get; set; }
        public double TinhTien
        {
            get
            {
                if (IsSinhVien)
                {
                    return SoLuongMua * GiaBasic * 0.95;
                    
                }
                else
                {
                    return SoLuongMua * GiaBasic;
                }
            }
            
        }
    }
}
