using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMatematikOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi1, sayi2;
        string op;

        private void Form1_Load(object sender, EventArgs e)
        {
            SayiUret();
            tmrSure.Start();
        }

        void SayiUret()
        {
            op = lblOperator.Text.ToString();
            sayi1 = rnd.Next(0, 10);
            sayi2 = rnd.Next(0, 10);
            lblSayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();
        }

        int seviye, toplamSoru, dogruSoru, yanlisSoru;

        void Sonuc(int x, int y, string op1)
        {

            seviye = Convert.ToInt32(lblSeviye.Text);
            if (1 <= seviye && seviye <= 6)
            {
                op = "+";
                lblOperator.Text = op;
            }

            else if (seviye >= 6 && seviye < 11)
            {
                op = "-";
                lblOperator.Text = op;
            }

            else if (seviye >= 11 && seviye < 16)
            {
                op = "*";
                lblOperator.Text = op;
            }

            else if (seviye >= 16 && seviye <= 20)
            {
                op = "/";
                lblOperator.Text = op;
            }

            int sonucum=0;
            toplamSoru = Convert.ToInt32(lblToplam.Text);
            dogruSoru = Convert.ToInt32(lblDogru.Text);
            yanlisSoru = Convert.ToInt32(lblYanlis.Text);
            seviye = Convert.ToInt32(lblSeviye.Text);

            switch (op1)
            {
                case "+":
                    sonucum = x + y;
                    break;
                case "-":
                    sonucum = x - y;
                    break;
                case "*":
                    sonucum = x * y;
                    break;
                case "/":
                    sonucum = x / y;
                    break;
            }

            if (sonucum == Convert.ToInt32(tbSonuc.Text))
            {
                seviye++;
                toplamSoru++;
                dogruSoru++;
                lblSeviye.Text = seviye.ToString();
                lblToplam.Text = toplamSoru.ToString();
                lblDogru.Text = dogruSoru.ToString();
            }
            else if (sonucum != Convert.ToInt32(tbSonuc.Text))
            {
                seviye--;
                toplamSoru++;
                yanlisSoru++;
                lblSeviye.Text = seviye.ToString();
                lblToplam.Text = toplamSoru.ToString();
                lblYanlis.Text = yanlisSoru.ToString();
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            tmrSure.Start();
            Sonuc(sayi1, sayi2,op);
            SayiUret();
            tbSonuc.Clear();
            sure = 11;
        }

        int sure = 11;
        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;

            lblTime.Text = sure.ToString();

            if (lblTime.Text == "0")
            {
                tmrSure.Stop();
                seviye--;
                lblSeviye.Text = seviye.ToString();
                toplamSoru++;
                lblToplam.Text = toplamSoru.ToString();
                sure = 11;
                SayiUret();
                tmrSure.Start();

            }

        }
    }
}
