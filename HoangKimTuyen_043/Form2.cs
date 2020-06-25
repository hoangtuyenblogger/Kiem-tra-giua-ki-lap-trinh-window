using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoangKimTuyen_043
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_caculator_Click(object sender, EventArgs e)
        {
            Library lib = new Library();
            double chuvi, dientich;
            double a, b, c;

            a = double.Parse(txtCanha.Text);
            b = double.Parse(txtCanhb.Text);
            c = double.Parse(txtCanhc.Text);

            // sự kiện tab 1
            // kiểm tra xem có phải tam giác không

            if (!lib.KiemTraTamGiac(a, b, c))
            {
                MessageBox.Show("Đây không phải là 1 tam giác !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                a = double.Parse(txtCanha.Text);
                b = double.Parse(txtCanhb.Text);
                c = double.Parse(txtCanhc.Text);

                chuvi = lib.ChuviTamGiac(a, b, c);
                dientich = lib.DientichTamGiac(a, b, c);

                // hiển thị kết quả ra text box
                txtChuviTamGiac.Text = chuvi.ToString();
                txtDientichTamGiac.Text = dientich.ToString();
            }

         }

        private void button1_Click(object sender, EventArgs e)
        {
            Library lib = new Library();
            // sự kiện tab 2
            double chieudai, chieurong, chuviHCN, dientichHCN;
            chieudai = double.Parse(txtChieudai.Text);
            chieurong = double.Parse(txtChieurong.Text);
            chuviHCN = lib.ChuViHCN(chieudai, chieurong);
            dientichHCN = lib.DienTichHCN(chieudai, chieurong);
            // hiển thị kết quả ra text box
            txtChuviHCN.Text = chuviHCN.ToString();
            txtDientichHCN.Text = dientichHCN.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Library lib = new Library();
            // sự kiện tab 3
            double r, chuviHinhTron, dientichHinhTron;
            r = double.Parse(txtBankinh.Text);
            chuviHinhTron = lib.ChuViHinhTron(r);
            dientichHinhTron = lib.DienTichHinhTron(r);

            // hiển thị kết quả ra text box
            txtChuviHinhTron.Text = chuviHinhTron.ToString();
            txtDientichHinhTron.Text = dientichHinhTron.ToString();
        }        
    }
}
