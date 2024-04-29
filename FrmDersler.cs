using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.tblDerslerTableAdapter ds = new DataSet1TableAdapters.tblDerslerTableAdapter();

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.dersListesi();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.dersEkle(txtDersAd.Text);
            MessageBox.Show("Ders Ekleme Islemi Yapilmistir");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.dersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.dersSil(byte.Parse(txtDersID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.dersGuncelle(txtDersAd.Text, byte.Parse(txtDersID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
