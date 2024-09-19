using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienBanSach
{
    public partial class Form1 : Form
    {
        DanhSachKhachHang database = new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTInh_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Name = txtTen.Text;
            kh.SoLuongMua = int.Parse(txtSoLuong.Text);
            kh.IsSinhVien = checkSV.Checked;
            database.Mua(kh);

            txtThanhTien.Text = kh.TinhTien + "";

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSoLuong.Text = "";
            checkSV.Checked = false;
            txtThanhTien.Text = "";
            txtTen.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTongKhach.Text = database.TongSoKhachHang + "";
            txtTongSV.Text = database.TongSoKhachLaSinhVien + "";
            txtTongDoanhThu.Text = database.TongDoanhThu + "";
        }

        private void txtTongKhach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKH = new Form();
            frmKH.Width = frmKH.Height = 300;
            ListBox lstKh = new ListBox();
            frmKH.Controls.Add(lstKh);
            lstKh.Dock = DockStyle.Fill;
            foreach(KhachHang kh in database.khachs)
            {
                lstKh.Items.Add(kh.Name);

            }
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            frmKH.Show();
        }

        private void txtTongSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKH = new Form();
            frmKH.Width = frmKH.Height = 300;
            ListBox lstKh = new ListBox();
            frmKH.Controls.Add(lstKh);
            lstKh.Dock = DockStyle.Fill;
            foreach (KhachHang kh in database.khachs)
            {
                if(kh.IsSinhVien)
                    lstKh.Items.Add(kh.Name);

            }
            frmKH.StartPosition = FormStartPosition.CenterScreen;
            frmKH.Show();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không", "Hỏi thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
