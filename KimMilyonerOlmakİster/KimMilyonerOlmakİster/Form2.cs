using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimMilyonerOlmakİster
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac_soru;
        int sayac_cevap;
        int zaman = 30;
        bool durum1 = false;
        string[] sorular = new string[10];
        string[] CevapA = new string[10];
        string[] CevapB = new string[10];
        string[] CevapC = new string[10];
        string[] CevapD = new string[10];
        string[] DogruCevap = new string[10];
        string instenencevap = "";

        Random rastegele = new Random();

        private void yenile()
        {
            sayac_soru = 0;
            sayac_cevap = 0;
            instenencevap = "";

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;



            sorular[0] = "Bir durum karşısında coşkuya kapılıp duygulananlar için kullanılan ifade hangisi olur";
            CevapA[0] = "A) Kendinden döndü";
            CevapB[0] = "B) Kendinden çekti";
            CevapC[0] = "C) Kendinden taştı";
            CevapD[0] = "D) Kendinden geçti";

            DogruCevap[0] = "D) Kendinden geçti";

            //----------------------------------------------------------------------------------------------------------------//

            sorular[1] = "Tavlada zarların fincanla atılmasını isteyenlerin engel olmak istedikleri şey hangisidir?";
            CevapA[1] = "A) Pul çalma";
            CevapB[1] = "B) Zar tutma";
            CevapC[1] = "C) Tavla devirme";
            CevapD[1] = "D) Düşeş atma";

            DogruCevap[1] = "B) Zar tutma";

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[2] = "3 Idiots, PK Dangal ve geçtiğimiz günlerde vizyona giren Hindistan Eşkıyaları filmlerinde başrol oynayan Hint aktör, yönetmen ve yapımcı kimdir?";
            CevapA[2] = "A) Raaj Kumar";
            CevapB[2] = "B) Shah Rukh Khan";
            CevapC[2] = "C) Raj Kapoor";
            CevapD[2] = "D) Aamir Khan";

            DogruCevap[2] = "D) Aamir Khan";

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[3] = "Daily Planet muhabiri Clark Kent, telefon kulübesine girip, kılık değiştirdikten sonra hangisi olarak dışarı çıkar?";
            CevapA[3] = "A) Batman";
            CevapB[3] = "B) He-Man";
            CevapC[3] = "C) Süpermen";
            CevapD[3] = "D) Kaptan Mağara Adamı";

            DogruCevap[3] = "C) Süpermen";

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[4] = "Kuşları inceleyen bilim dalı hangisidir?";
            CevapA[4] = "A) Paleontoloji";
            CevapB[4] = "B) Arekoloji";
            CevapC[4] = "C) Etimoloji";
            CevapD[4] = "D) Ornitoloji";

            DogruCevap[4] = "D) Ornitoloji";

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[5] = "Tutunamayanlar ve Tehlikeli Oyunlar romanlarının yazarı kimdir?";
            CevapA[5] = "A) Yusuf Atılgan";
            CevapB[5] = "B) Oğuz Atay";
            CevapC[5] = "C) Ahmet Hamdi Tanpınar";
            CevapD[5] = "D) Sabahattin Ali";

            DogruCevap[5] = "B) Oğuz Atay";

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[6] = "Taumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitanatahu Tepesi nerededir?";
            CevapA[6] = "A) Hawai";
            CevapB[6] = "B) Yeni Zelanda";
            CevapC[6] = "C) Galler";
            CevapD[6] = "D) Hindistan";

            DogruCevap[6] = "B) Yeni Zelanda";

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[7] = "Çubuklara geçirilmiş küçük bayraklarla işaretlenmiş bir parkurda, belli kurallara göre ve zikzaklar çizerek yapılan kayak yarışı hangisidir?";
            CevapA[7] = "A) Skeleton";
            CevapB[7] = "B) Pentatlon";
            CevapC[7] = "C) Slalom";
            CevapD[7] = "D) Maraton";

            DogruCevap[7] = "C) Slalom";

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[8] = "Memleketlerinin plaka kodunu forma numarası yapan dört kişiden hangisinin numarası aynı iki rakamdan oluşmaz?";
            CevapA[8] = "A) Mersinli olanın";
            CevapB[8] = "B) Zonguldaklı olanın";
            CevapC[8] = "C) Malatyalı olanın";
            CevapD[8] = "D) Samsunlu olanın";

            DogruCevap[8] = "B) Zonguldaklı olanın";

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            sorular[9] = "10 Kıtadan oluşan istiklal marşının tamamında bu kelimelerden hangisi diğerlerinden az geçer?";
            CevapA[9] = "A) Vatan";
            CevapB[9] = "B) Kan";
            CevapC[9] = "C) Toprak";
            CevapD[9] = "D) Yurt";

            DogruCevap[9] = "C) Toprak";

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            label1.Text = sorular[sayac_soru];
            button1.Text = CevapA[sayac_cevap];
            button2.Text = CevapB[sayac_cevap];
            button3.Text = CevapC[sayac_cevap];
            button4.Text = CevapD[sayac_cevap];

            progressBar1.Value = 10;
            label2.ForeColor = Color.White;
            zaman = 30;
            timer1.Start();

            button5.Enabled = true;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            yenile();
            pictureBox1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            instenencevap = button1.Text;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label2.ForeColor = Color.White;

            if (progressBar1.Value == 70)
            {
                DialogResult gericekil = new DialogResult();
                timer1.Stop();
                gericekil = MessageBox.Show("15.000 TL Kazandınız Bu Parayla Ayrılmak ister misiniz?", "2.Baraj", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (gericekil == DialogResult.Yes)
                {
                    MessageBox.Show("15.000 TL Kazandınız Tebrikler!");
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Devam Diyorsunuz Tebrik ederiz, Tüm soruları bilmeniz dileğiyle");
                }
            }

            if (progressBar1.Value == 10)
            {
                pictureBox2.Visible = true;
            }

            if (progressBar1.Value == 20)
            {
                pictureBox3.Visible = true;
            }

            if (progressBar1.Value == 30)
            {
                pictureBox4.Visible = true;
            }

            if (progressBar1.Value == 40)
            {
                pictureBox5.Visible = true;
            }

            if (progressBar1.Value == 50)
            {
                pictureBox6.Visible = true;
            }

            if (progressBar1.Value == 60)
            {
                pictureBox7.Visible = true;
            }

            if (progressBar1.Value == 70)
            {
                pictureBox8.Visible = true;
            }

            if (progressBar1.Value == 80)
            {
                pictureBox9.Visible = true;
            }

            if (progressBar1.Value == 90)
            {
                pictureBox10.Visible = true;
            }

            if (progressBar1.Value == 100)
            {
                pictureBox10.Visible = true;
            }

            try
            {
                if (instenencevap == DogruCevap[sayac_cevap])
                {
                    sayac_soru++;
                    sayac_cevap++;

                    label1.Text = sorular[sayac_soru];

                    button1.Text = CevapA[sayac_cevap];
                    button2.Text = CevapB[sayac_cevap];
                    button3.Text = CevapC[sayac_cevap];
                    button4.Text = CevapD[sayac_cevap];

                    progressBar1.Value = progressBar1.Value + 10;

                    zaman = 30;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    durum1 = true;
                    DialogResult bitti = new DialogResult();
                    bitti = MessageBox.Show("Malesef Yanlış Cevap Verdiniz, Tekrar Başlayarak Doğru Cevabı Bulabilirsiniz!", "Yanlış Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (bitti == DialogResult.Yes)
                    {
                        zaman = 0;
                        yenile();
                        timer1.Start();
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                if (durum1 == false)
                {
                    timer1.Stop();
                    DialogResult allcheck = new DialogResult();
                    allcheck = MessageBox.Show("Tebrikler Hepsini Doğru Cevaplayarak 1.000.000 TL Almaya Hak Kazandınız! Tekrar Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (allcheck == DialogResult.Yes)
                    {
                        yenile();
                        zaman = 30;
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {

                }
            }
        }


        private void button7_Click(object sender, EventArgs e)    // yarı yarıya
        {
            button7.Enabled = false;
            if (sayac_soru == 0)
            {
                button2.Visible = false;
                button3.Visible = false;
            }

            else if (sayac_soru == 1)
            {
                button1.Visible = false;
                button3.Visible = false;
            }

            else if (sayac_soru == 2)
            {
                button1.Visible = false;
                button3.Visible = false;
            }

            else if (sayac_soru == 3)
            {
                button2.Visible = false;
                button4.Visible = false;
            }

            else if (sayac_soru == 4)
            {
                button2.Visible = false;
                button3.Visible = false;
            }

            else if (sayac_soru == 5)
            {
                button1.Visible = false;
                button4.Visible = false;
            }

            else if (sayac_soru == 6)
            {
                button3.Visible = false;
                button4.Visible = false;
            }

            else if (sayac_soru == 7)
            {
                button2.Visible = false;
                button4.Visible = false;
            }

            else if (sayac_soru == 8)
            {
                button1.Visible = false;
                button3.Visible = false;
            }

            else if (sayac_soru == 9)
            {
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            zaman--;
            label2.Text = zaman.ToString();

            if (zaman <= 15)
            {
                label2.ForeColor = Color.Red;
            }

            DialogResult sy = new DialogResult();


            if (zaman < 1)
            {
                timer1.Stop();
                sy = MessageBox.Show("Süre Bitti Tekrar Başlamak İster misiniz");

                if (sy == DialogResult.Yes)
                {
                    yenile();
                    label2.ForeColor = Color.White;
                }

                else
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            instenencevap = button2.Text;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label2.ForeColor = Color.White;

            if (progressBar1.Value == 70)
            {
                DialogResult gericekil = new DialogResult();
                timer1.Stop();
                gericekil = MessageBox.Show("15.000 TL Kazandınız Bu Parayla Ayrılmak ister misiniz?", "2.Baraj", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (gericekil == DialogResult.Yes)
                {
                    MessageBox.Show("15.000 TL Kazandınız Tebrikler!");
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Devam Diyorsunuz Tebrik ederiz, Tüm soruları bilmeniz dileğiyle");
                }
            }

            if (progressBar1.Value == 10)
            {
                pictureBox2.Visible = true;
            }

            if (progressBar1.Value == 20)
            {
                pictureBox3.Visible = true;
            }

            if (progressBar1.Value == 30)
            {
                pictureBox4.Visible = true;
            }

            if (progressBar1.Value == 40)
            {
                pictureBox5.Visible = true;
            }

            if (progressBar1.Value == 50)
            {
                pictureBox6.Visible = true;
            }

            if (progressBar1.Value == 60)
            {
                pictureBox7.Visible = true;
            }

            if (progressBar1.Value == 70)
            {
                pictureBox8.Visible = true;
            }

            if (progressBar1.Value == 80)
            {
                pictureBox9.Visible = true;
            }

            if (progressBar1.Value == 90)
            {
                pictureBox10.Visible = true;
            }

            if (progressBar1.Value == 100)
            {
                pictureBox10.Visible = true;
            }

            try
            {
                if (instenencevap == DogruCevap[sayac_cevap])
                {
                    sayac_soru++;
                    sayac_cevap++;

                    label1.Text = sorular[sayac_soru];

                    button1.Text = CevapA[sayac_cevap];
                    button2.Text = CevapB[sayac_cevap];
                    button3.Text = CevapC[sayac_cevap];
                    button4.Text = CevapD[sayac_cevap];

                    progressBar1.Value = progressBar1.Value + 10;

                    zaman = 30;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    durum1 = true;
                    DialogResult bitti = new DialogResult();
                    bitti = MessageBox.Show("Malesef Yanlış Cevap Verdiniz, Tekrar Başlayarak Doğru Cevabı Bulabilirsiniz!", "Yanlış Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (bitti == DialogResult.Yes)
                    {
                        zaman = 0;
                        yenile();
                        timer1.Start();
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                if (durum1 == false)
                {
                    timer1.Stop();
                    DialogResult allcheck = new DialogResult();
                    allcheck = MessageBox.Show("Tebrikler Hepsini Doğru Cevaplayarak 1.000.000 TL Almaya Hak Kazandınız! Tekrar Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (allcheck == DialogResult.Yes)
                    {
                        yenile();
                        zaman = 30;
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            instenencevap = button3.Text;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label2.ForeColor = Color.White;

            if (progressBar1.Value == 70)
            {
                DialogResult gericekil = new DialogResult();
                timer1.Stop();
                gericekil = MessageBox.Show("15.000 TL Kazandınız Bu Parayla Ayrılmak ister misiniz?", "2.Baraj", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (gericekil == DialogResult.Yes)
                {
                    MessageBox.Show("15.000 TL Kazandınız Tebrikler!");
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Devam Diyorusunuz Tebrik ederiz, Tüm soruları bilmeniz dileğiyle");
                }
            }

            if (progressBar1.Value == 10)
            {
                pictureBox2.Visible = true;
            }

            if (progressBar1.Value == 20)
            {
                pictureBox3.Visible = true;
            }

            if (progressBar1.Value == 30)
            {
                pictureBox4.Visible = true;
            }

            if (progressBar1.Value == 40)
            {
                pictureBox5.Visible = true;
            }

            if (progressBar1.Value == 50)
            {
                pictureBox6.Visible = true;
            }

            if (progressBar1.Value == 60)
            {
                pictureBox7.Visible = true;
            }

            if (progressBar1.Value == 70)
            {
                pictureBox8.Visible = true;
            }

            if (progressBar1.Value == 80)
            {
                pictureBox9.Visible = true;
            }

            if (progressBar1.Value == 90)
            {
                pictureBox10.Visible = true;
            }

            if (progressBar1.Value == 100)
            {
                pictureBox10.Visible = true;
            }

            try
            {
                if (instenencevap == DogruCevap[sayac_cevap])
                {
                    sayac_soru++;
                    sayac_cevap++;

                    label1.Text = sorular[sayac_soru];

                    button1.Text = CevapA[sayac_cevap];
                    button2.Text = CevapB[sayac_cevap];
                    button3.Text = CevapC[sayac_cevap];
                    button4.Text = CevapD[sayac_cevap];

                    progressBar1.Value = progressBar1.Value + 10;

                    zaman = 30;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    durum1 = true;
                    DialogResult bitti = new DialogResult();
                    bitti = MessageBox.Show("Malesef Yanlış Cevap Verdiniz, Tekrar Başlayarak Doğru Cevabı Bulabilirsiniz!", "Yanlış Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (bitti == DialogResult.Yes)
                    {
                        zaman = 0;
                        yenile();
                        timer1.Start();
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                if (durum1 == false)
                {
                    timer1.Stop();
                    DialogResult allcheck = new DialogResult();
                    allcheck = MessageBox.Show("Tebrikler Hepsini Doğru Cevaplayarak 1.000.000 TL Almaya Hak Kazandınız! Tekrar Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (allcheck == DialogResult.Yes)
                    {
                        yenile();
                        zaman = 30;
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            instenencevap = button4.Text;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label2.ForeColor = Color.White;

            if (progressBar1.Value == 70)
            {
                DialogResult gericekil = new DialogResult();
                timer1.Stop();
                gericekil = MessageBox.Show("15.000 TL Kazandınız Bu Parayla Ayrılmak ister misiniz?", "2.Baraj", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (gericekil == DialogResult.Yes)
                {
                    MessageBox.Show("15.000 TL Kazandınız Tebrikler!");
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Devam Diyorsunuz Tebrik ederiz, Tüm soruları bilmeniz dileğiyle");
                }
            }

            if (progressBar1.Value == 10)
            {
                pictureBox2.Visible = true;
            }

            if (progressBar1.Value == 20)
            {
                pictureBox3.Visible = true;
            }

            if (progressBar1.Value == 30)
            {
                pictureBox4.Visible = true;
            }

            if (progressBar1.Value == 40)
            {
                pictureBox5.Visible = true;
            }

            if (progressBar1.Value == 50)
            {
                pictureBox6.Visible = true;
            }

            if (progressBar1.Value == 60)
            {
                pictureBox7.Visible = true;
            }

            if (progressBar1.Value == 70)
            {
                pictureBox8.Visible = true;
            }

            if (progressBar1.Value == 80)
            {
                pictureBox9.Visible = true;
            }

            if (progressBar1.Value == 90)
            {
                pictureBox10.Visible = true;
            }

            if (progressBar1.Value == 100)
            {
                pictureBox10.Visible = true;
            }

            try
            {
                if (instenencevap == DogruCevap[sayac_cevap])
                {
                    sayac_soru++;
                    sayac_cevap++;

                    label1.Text = sorular[sayac_soru];

                    button1.Text = CevapA[sayac_cevap];
                    button2.Text = CevapB[sayac_cevap];
                    button3.Text = CevapC[sayac_cevap];
                    button4.Text = CevapD[sayac_cevap];

                    progressBar1.Value = progressBar1.Value + 10;

                    zaman = 30;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    durum1 = true;
                    DialogResult bitti = new DialogResult();
                    bitti = MessageBox.Show("Malesef Yanlış Cevap Verdiniz, Tekrar Başlayarak Doğru Cevabı Bulabilirsiniz!", "Yanlış Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (bitti == DialogResult.Yes)
                    {
                        zaman = 0;
                        yenile();
                        timer1.Start();
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                if (durum1 == false)
                {
                    timer1.Stop();
                    DialogResult allcheck = new DialogResult();
                    allcheck = MessageBox.Show("Tebrikler Hepsini Doğru Cevaplayarak 1.000.000 TL Almaya Hak Kazandınız! Tekrar Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (allcheck == DialogResult.Yes)
                    {
                        yenile();
                        zaman = 30;
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {

                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.active;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.passive;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.active;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.passive;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.active;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.passive;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.active;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.passive;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.yarıyarıya;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.yarıyarıya2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
