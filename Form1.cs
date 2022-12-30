using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _temizlencekMi;
        int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            temizle();
            if (ekranLabel.Text == "0"){
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {

            temizle();
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "0";
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _temizlencekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        // Ekran Temizleme Fonksiyonu
        public void temizle()
        {
            if (_temizlencekMi)
            {
                ekranLabel.Text = "";
                _temizlencekMi = false;   
            }
        }

        private void buttonEssittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem){
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _temizlencekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _temizlencekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _temizlencekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            _temizlencekMi = false;
            ekranLabel.Text = Convert.ToString(0);
        }
    }

    
}
 