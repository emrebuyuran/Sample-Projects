using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseArithmetic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int sayi, kalan;
        string tutKalan = "";


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tutKalan = "";
            if (cbxBase.SelectedIndex == -1)
            {
                MessageBox.Show("Taban Seçiniz ", "Hata", MessageBoxButtons.OK);
                return;
            }


            sayi = Convert.ToInt32(tbxNumber.Text);

            if (sayi < 10 || sayi > 99)
            {
                MessageBox.Show("Girilen değer çok küçük veya bir tamsayı değil ! Lütfen 9'dan büyük, 99'dan küçük iki basamaklı bir sayı giriniz.", "Hata", MessageBoxButtons.OK);
                return;
            }
            if (sayi >= 10 && sayi <= 99)
            {

                while (sayi != 0 && cbxBase.SelectedIndex == 0)
                {
                    kalan = sayi % 2;
                    sayi /= 2;
                    tutKalan = kalan.ToString() + tutKalan;
                    tbxResult.Text = tutKalan;


                }

                while (sayi != 0 && cbxBase.SelectedIndex == 1)
                {
                    kalan = sayi % 3;
                    sayi /= 3;
                    tutKalan = kalan.ToString() + tutKalan;
                    tbxResult.Text = tutKalan;



                }
                while (sayi != 0 && cbxBase.SelectedIndex == 2)
                {
                    kalan = sayi % 4;
                    sayi /= 4;
                    tutKalan = kalan.ToString() + tutKalan;
                    tbxResult.Text = tutKalan;


                }
                while (sayi != 0 && cbxBase.SelectedIndex == 3)
                {
                    kalan = sayi % 5;
                    sayi /= 5;
                    tutKalan = kalan.ToString() + tutKalan;
                    tbxResult.Text = tutKalan;


                }
                while (sayi != 0 && cbxBase.SelectedIndex == 4)
                {
                    kalan = sayi % 6;
                    sayi /= 6;
                    tutKalan = kalan.ToString() + tutKalan;
                    tbxResult.Text = tutKalan;


                }
            }


        }

        private void tbxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxNumber_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
