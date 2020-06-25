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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show(" Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dia == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void solveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 new_form = new Form2();
            new_form.Visible = true;
        }
    }
}
