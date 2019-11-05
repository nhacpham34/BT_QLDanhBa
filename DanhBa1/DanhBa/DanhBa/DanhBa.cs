using DanhBa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class DanhBa : Form
    {
        public static string pathDataGroup;
        public static string pathDataContact;
        public static List<Nhom> listNhom;
        
        public DanhBa()
        {
            InitializeComponent();
            
            pathDataGroup = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + @"Data\nhom.data";
            pathDataContact = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + @"Data\lienlac.data";

            loadNhom();
            if (dataGridView_nhom.Rows.Count > 0)
                dataGridView_nhom.Rows[0].Selected = false;
        }
        void loadNhom()
        {
            listNhom = Nhom.getListNhom(pathDataGroup);

            bindingSource_nhom.DataSource = listNhom;
            dataGridView_nhom.DataSource = bindingSource_nhom;
        }
        private void dataGridView_nhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingSource_lienLac.DataSource = LienLac.getContactList(pathDataContact, (bindingSource_nhom.Current as Nhom).MaNhom);
            dataGridView_lienLac.DataSource = bindingSource_lienLac;
            if(dataGridView_lienLac.Rows.Count>0)
                dataGridView_lienLac.Rows[0].Selected = false;
        }

        private void dataGridView_lienLac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ten.Text = (bindingSource_lienLac.Current as LienLac).TenLienLac;
            textBox_email.Text = (bindingSource_lienLac.Current as LienLac).Email;
            textBox_soDienThoai.Text = (bindingSource_lienLac.Current as LienLac).SoDienThoai;
            textBox_diaChi.Text = (bindingSource_lienLac.Current as LienLac).DiaChi;
        }

        private void toolStripButton_xoaNhom_Click(object sender, EventArgs e)
        {
            Nhom nhom = (bindingSource_nhom.Current as Nhom);
            if (MessageBox.Show("Bạn có muốn xóa nhóm \"" + nhom.TenNhom+"\" không?", "Xóa nhóm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Nhom.xoaNhom(pathDataGroup, nhom.MaNhom);
                loadNhom();
            }
        }

        private void toolStripButton_xoaLienLac_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_themLienLac_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_themNhom_Click(object sender, EventArgs e)
        {
            ThemNhom f = new ThemNhom();
            f.ShowDialog();
            loadNhom();
        }
    }
}
