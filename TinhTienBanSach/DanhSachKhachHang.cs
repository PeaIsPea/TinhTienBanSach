using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienBanSach
{
    public class DanhSachKhachHang
    {
        List<KhachHang> dsKH = new List<KhachHang>();
        public List<KhachHang> khachs
        {
            get { return dsKH; }
        }
        public void Mua(KhachHang kh)
        {
            dsKH.Add(kh);
        }
        public int TongSoKhachHang
        {
            get { return dsKH.Count; }


        }
        public int TongSoKhachLaSinhVien
        {
            get
            {
                int soSV = 0;
                foreach (KhachHang kh in dsKH)
                {
                    if (kh.IsSinhVien) soSV++;
                }
                return soSV;
            }
        }

        public double TongDoanhThu
        {
            get
            {
                double sum = 0;
                foreach(KhachHang kh in dsKH)
                {
                    sum += kh.TinhTien;
                }
                return sum;
            }

        }
    }
}
