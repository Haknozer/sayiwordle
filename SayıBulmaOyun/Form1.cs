using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Timer = System.Windows.Forms.Timer;

namespace SayıBulmaOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        int textboxId = 1;
        List<int> list = new List<int>();
        List<String> colorList = new List<String>();
        Timer timer = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {   
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            Random rnd = new Random();
            if (radioButton1.Checked)
            {
                if (numericUpDown1.Value < 5)
                {
                    for (int n = 1; n <= 5 - numericUpDown1.Value; n++)
                    {
                        TextBox txt = (TextBox)this.Controls["textBox" + n];
                        txt.Enabled = false;
                    }
                }
                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    int yeni = rnd.Next(1, 10);
                    list.Add(yeni);
                }
                textboxId = 1;
            }
            else if (radioButton2.Checked)
            {
                if (numericUpDown1.Value < 5)
                {
                    for (int n = 1; n <= 5 - numericUpDown1.Value; n++)
                    {
                        TextBox txt = (TextBox)this.Controls["textBox" + n];
                        txt.Enabled = false;
                    }
                }
                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    int yeni;
                    do
                    {
                        yeni = rnd.Next(1, 10);
                    } while (list.Contains(yeni));
                    list.Add(yeni);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            int z = 0;
            label5.Text = numericUpDown2.Value.ToString();
            int sayac = 5 - Convert.ToInt32(numericUpDown1.Value);
            while (z < sayac)
            {
                colorList.Add("");
                z++;
            }

            while (sayac < 5)
            {
                colorList.Add("Yellow");
                sayac++;
            }
            
        }
        int y = 0;
        int zamanSayac = 10;
        bool kontrol = false;
        private void button2_Click(object sender, EventArgs e)
        {
            int textBoxID = 5;
            int i = 0;
            while (i < numericUpDown1.Value)
            {
                TextBox txt = (TextBox)this.Controls["textBox" + textBoxID];
                Panel panel = (Panel)this.Controls["panel" + textBoxID];
                int sayi = Convert.ToInt32(txt.Text);
                if (sayi == list[i])
                {
                    panel.BackColor = Color.Green;
                    colorList[textBoxID - 1] = "Green";
                }
                else
                {
                    if (list.Contains(sayi))
                    {
                        panel.BackColor = Color.Blue;
                        colorList[textBoxID - 1] = "Blue";
                    }
                    else
                    {
                        panel.BackColor = Color.Yellow;
                        colorList[textBoxID - 1] = "Yellow";
                    }
                }
                textBoxID--;
                i++;
            }

            if (!colorList.Any(x => x.Equals("Yellow")) && !colorList.Any(x => x.Equals("Blue")))
            {
                label3.Text = "TEBRİKLER KAZANDINIZ";
                timer.Stop();
                kontrol = true;
                oyunDialog();
            }

            oyunKontrol();
            zamanSayac = 10;
            y++;
            label5.Text = (numericUpDown2.Value - y).ToString();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            zamanSayac--;
            label2.Text = zamanSayac.ToString();
            if (zamanSayac == 0)
            {
               y++;
                oyunKontrol();
               zamanSayac = 10;
               label2.Text = zamanSayac.ToString();
            }
            label5.Text = (numericUpDown2.Value - y).ToString();
        }

        void oyunKontrol()
        {
            if (kontrol == false && y == numericUpDown2.Value)
            {
                label3.Text = "KAZANAMADINIZ SAYI : ";
                list.Reverse();
                foreach (var sayi in list)
                {
                    label3.Text += sayi.ToString();
                }
                timer.Stop();
                oyunDialog();
            }
        }

        void oyunDialog() {
            DialogResult res = MessageBox.Show("Oyuna Devam Etmek İstemisin", "Oyun Bitti", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Restart();
            }
            if (res == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
