using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum1soal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbsuhudari.SelectedIndex = 0;
            cbsuhudari.DropDownStyle = ComboBoxStyle.DropDownList;
            txthasil.ReadOnly = true;
        }

        private double konversi(double suhudari, double suhuke, double inputsuhu)
        {
            if(suhudari == 0 && suhuke == 2)
            {
                return (inputsuhu * 1.8) + 32;
            }
            else if(suhudari == 0 && suhuke == 3)
            {
                return inputsuhu * 0.8;
            }
            else if(suhudari == 1 && suhuke == 1)
            {
                return (inputsuhu - 32) / 1.8;
            }
            else if(suhudari == 1 && suhuke == 3)
            {
                return (inputsuhu - 32) / 2.25;
            }
            else if(suhudari == 2 && suhuke == 1)
            {
                return inputsuhu * 1.25;
            }
            else if(suhudari == 2 && suhuke == 2)
            {
                return inputsuhu * 2.25 + 32;
            }
            else
            {
                return inputsuhu;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int suhuke = 0,
            suhudari = cbsuhudari.SelectedIndex,
            inputsuhu = int.Parse(txtsuhudari.Text);
                string hasilkonv = "";

                if (rbcelcius.Checked)
                {
                    suhuke = 1;
                    hasilkonv = Convert.ToString(Math.Round(konversi(suhudari, suhuke, inputsuhu), 2)) + " Celcius";
                }
                else if (rbfahrenheit.Checked)
                {
                    suhuke = 2;
                    hasilkonv = Convert.ToString(Math.Round(konversi(suhudari, suhuke, inputsuhu), 2)) + " Fahrenheit";
                }
                else if (rbreamur.Checked)
                {
                    suhuke = 3;
                    hasilkonv = Convert.ToString(Math.Round(konversi(suhudari, suhuke, inputsuhu), 2)) + " Reamur";
                }

                txthasil.Text = hasilkonv;

            }
            catch
            {
                txthasil.Text = "Masukan Input !!";
            }


        }
    }
}
