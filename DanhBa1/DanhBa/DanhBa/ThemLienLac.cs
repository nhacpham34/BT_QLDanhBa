using DanhBa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class ThemLienLac : Form
    {
        public ThemLienLac()
        {
            InitializeComponent();
            bindingSource_nhom.DataSource = DanhBa.listNhom;
            comboBox1.DataSource = bindingSource_nhom;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            //LienLac.themLienLac(DanhBa.pathDataContact, textBox_tenLienLac.Text, textBox_email.Text, textBox_soDienThoai.Text, textBox_diaChi.Text,);
            DialogResult = DialogResult.OK;
        }
    }
}
