using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtanak.Visible = true;
            txtanak.Focus();
            txtgaji.Focus();
            txthasil.ReadOnly = true;
        }

        

        private void btnhasil_Click(object sender, EventArgs e)
        {
            double hasil = 0, gaji, anak;

            if (rblaki.Checked == true && sudah.Checked == true)
            {
                anak = double.Parse(txtanak.Text);
                gaji = double.Parse(txtgaji.Text);
                if (anak <= 3 && anak > 0)
                {
                    hasil = hasil + 0.20 * anak * gaji;
                    txthasil.Text = hasil.ToString();
                }
                else if (anak>3)
                {
                    hasil = hasil + 0.60 * gaji;
                    txthasil.Text = hasil.ToString();
                }
                else
                {
                    MessageBox.Show("Tidak ada tunjangan");
                }
            }
            else
            {
                MessageBox.Show("Tidak ada tunjangan");
            }
        }

        private void txtanak_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
