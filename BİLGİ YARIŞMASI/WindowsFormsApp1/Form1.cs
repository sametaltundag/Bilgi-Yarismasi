using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void txtisim_TextChanged(object sender, EventArgs e)
        {
            if (txtisim.Text != "")
            {
                btnKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            ad = txtisim.Text;
            listBox1.Items.Add("Oyuncu Adı: " + ad);
            btnBasla.Enabled = true;
            btnKaydet.Visible = false;
            label6.Visible = false;
            pictureBox1.Visible = false;
            txtisim.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            labelpuan.Visible = true;
            labeldogru.Visible = true;
            labelyanlis.Visible = true;
            labelsoruno.Visible = true;
            btnBasla.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible= true;
            btnD.Visible = true;
            richTextBox1.Visible = true;
            
            MessageBox.Show("Oyuncu kaydı yapılmıştır :)" + "\n" + "\n" + "             İYİ OYUNLAR", "Samet'ten mesajın var!");
            
            
        }
        int soruno = 0, dogru = 0, yanlis = 0, puan = 0;

        private void btnC_Click(object sender, EventArgs e)
        {
            label9.Text = btnC.Text;
            if (label8.Text == label9.Text)
            {
                dogru = dogru + 1;
                labeldogru.Text = dogru.ToString();
                pictureBox3.Visible = true;
                puan = puan + 10;
                labelpuan.Text = puan.ToString();
            }
            else
            {
                yanlis = yanlis + 1;
                labelyanlis.Text = yanlis.ToString();
                puan = puan - 5;
                labelpuan.Text = puan.ToString();
                pictureBox4.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label9.Text = btnD.Text;
            if (label8.Text == label9.Text)
            {
                dogru = dogru + 1;
                labeldogru.Text = dogru.ToString();
                pictureBox3.Visible = true;
                puan = puan + 10;
                labelpuan.Text = puan.ToString();
            }
            else
            {
                yanlis = yanlis + 1;
                labelyanlis.Text = yanlis.ToString();
                puan = puan - 5;
                labelpuan.Text = puan.ToString();
                pictureBox4.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label9.Text = btnB.Text;
            if (label8.Text == label9.Text)
            {
                dogru = dogru + 1;
                labeldogru.Text = dogru.ToString();
                pictureBox3.Visible = true;
                puan = puan + 10;
                labelpuan.Text = puan.ToString();
            }
            else
            {
                yanlis = yanlis + 1;
                labelyanlis.Text = yanlis.ToString();
                puan = puan - 5;
                labelpuan.Text = puan.ToString();
                pictureBox4.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label9.Text = btnA.Text;
            if (label8.Text == label9.Text)
            {
                dogru = dogru + 1;
                labeldogru.Text = dogru.ToString();
                pictureBox3.Visible = true;
                puan = puan + 10;
                labelpuan.Text = puan.ToString();
            }
            else
            {
                yanlis = yanlis + 1;
                labelyanlis.Text = yanlis.ToString();
                puan = puan - 5;
                labelpuan.Text = puan.ToString();
                pictureBox4.Visible = true;
            }
            
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBasla.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            soruno = soruno + 1;
            labelsoruno.Text = soruno.ToString();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            if (soruno == 1)
            {
                btnBasla.Text = "Yeni Soru";
                richTextBox1.Text = "Tarihin sıfır noktası olarak bilinen, insanlık tarihinin ilk somut kalıntılarının bulunduğu Göbekli tepe hangi ilimizdedir?";
                btnA.Text = "Adıyaman";
                btnB.Text = "Şanlıurfa";
                btnC.Text = "İstanbul";
                btnD.Text = "Ankara";
                label8.Text = "Şanlıurfa";
                btnBasla.Enabled= false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Albert Einstein hangi alanda Nobel ödülü almıştır?";
                btnA.Text = "Kimya";
                btnB.Text = "Atom Bilimi";
                btnC.Text = "Fizik";
                btnD.Text = "Atom Enerjisi";
                label8.Text = "Fizik";

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Yüz ölçümü bakımından en büyük ülke hangisidir?";
                btnA.Text = "Rusya";
                btnB.Text = "Amerika";
                btnC.Text = "Çin Halk Cumhuriyeti";
                btnD.Text = "Mısır";
                label8.Text = "Rusya";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            } 
            if (soruno == 4)
            {
                richTextBox1.Text = "Hasis, kısık ve varyemez sözcükleriyle eş anlamlı olan sözcük hangisidir?";
                btnA.Text = "Açgözlü";
                btnB.Text = "Varyemez";
                btnC.Text = "Cömert";
                btnD.Text = "Cimri";
                label8.Text = "Cimri";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Haberleşmenin eski dildeki adı nedir?";
                btnA.Text = "Muhabere";
                btnB.Text = "Mektuplaşma";
                btnC.Text = "Fax";
                btnD.Text = "İttifak";
                label8.Text = "Muhabere";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 6)
            {
               richTextBox1.Text= "Osmanlıda şehzadelerin özel hocası, eğitmenlerine verilen isim";
                btnA.Text = "Lala";
                btnB.Text = "Paşa";
                btnC.Text = "Hünkar";
                btnD.Text = "Reis";
                label8.Text = "Lala";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Peygamberimiz'in babasının adı nedir?";
                btnA.Text = "Ebu Bekir";
                btnB.Text = "Abdulmuttalip";
                btnC.Text = "Kasım";
                btnD.Text = "Abdullah";
                label8.Text = "Abdullah";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Kız kalesi hangi ilimizdedir?";
                btnA.Text = "İstanbul";
                btnB.Text = "Mersin";
                btnC.Text = "Çanakkale";
                btnD.Text = "Denizli";
                label8.Text = "Mersin";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "'Kitabın özü' olarak bilinen surenin adı nedir?";
                btnA.Text = "Müdessir Suresi";
                btnB.Text = "Tevbe Suresi";
                btnC.Text = "Fatiha Suresi";
                btnD.Text = "Nur Suresi";
                label8.Text = "Fatiha Suresi";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Türkiye Cumhuriyeti Kimlik Numaramız kaç harften oluşur :D ";
                btnA.Text = "0";
                btnB.Text = "11";
                btnC.Text = "10";
                btnD.Text = "12";
                label8.Text = "0";
                
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnBasla.Enabled = false;
                btnBasla.Text = "SONUÇLAR";
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "OYUN BİTTİ :)";
                btnA.Text = "";
                btnB.Text = "";
                btnC.Text = "";
                btnD.Text = "";
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis + "\n" + "Puan: " + puan);
                listBox1.Items.Add("Puanı: " + puan);
                btnBasla.Enabled = false;
                    
            }
            if (puan == 100)
            {
                MessageBox.Show("Ne zeka varmış mübarek :D");
            }

            //INSTAGRAM ==>> samet_altundag63
            //INSTAGRAM ==>> samethecode
        }
    }
}
