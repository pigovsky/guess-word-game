using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Navigation
{
    public partial class MainForm : Form
    {
        public string EncryptionProvaider;//Провайдер який використовується для передачі введеного ключа, класу Encryptor.
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(36, 46, 59);
            this.panel1.BackColor = Color.FromArgb(26, 32, 46);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //При запуску програми проводиться провірка файлів
            string path = @"Data\\Pocket.data";//Шлях до файла в якому зберігається інформаціях про ключ
            var flen = new FileInfo(path).Length;
            if (flen != 0)//Якщо файл не пустий 
            {
                string Key = (new Decryption()).DecryptionReuslt.ToString();//Декодуємо інформацію, яка збергіається в файлі
                string[] split = Key.Split(new Char[] { '-' });// Використовуємо "Split" для розділення ключа за допомогою символа "-" 

                foreach (string s in split)
                {
                    if (split.Length == 4)//Провіка довжини ключа
                    {
                        ActivKod.Text = split[0];//Перша частина ключа до "-"
                        ActivKod1.Text = split[1];//Частина після першого "-"
                        ActivKod2.Text = split[2];//Частина після другого "-"
                        ActivKod3.Text = split[3];//Остання частина ключа "-"
                        ActivationStatus.Text = "Програму активовано";//Встановлюємо значення тексту Label на формі
                    }
                }
                //Оголошуємо змінні для провірки кнопок на формі
                string CheckSygicButton;
                string CheckIGONButton;
                string CheckIGOPButton;
                string CheckNavitelButton;
                //Провіряємо четверту кпопку
                string PocketInfopath3path = @"Data\\PocketInfopath3.data";
                var PocketInfopath3flen = new FileInfo(PocketInfopath3path).Length;
                if (PocketInfopath3flen != 0)
                {
                    DecryptionNavitelButton decryptionNavitel = new DecryptionNavitelButton();

                    string NavitelDecryptResult = (new DecryptionNavitelButton()).DecryptionReuslt.ToString();
                    CheckNavitelButton = NavitelDecryptResult.ToString();

                    if (NavitelDecryptResult == CheckNavitelButton)
                    {
                        Navitel_B.Enabled = true;
                    }
                }
                //Провіряэмо першу кнопку
                string PocketInfopathpath = @"Data\\PocketInfopath.data";
                var PocketInfopathflen = new FileInfo(PocketInfopathpath).Length;
                if (PocketInfopathflen != 0)
                {
                    DecryptionSygicButton DecryptSygicButton = new DecryptionSygicButton();

                    string SBDecryptResult = (new DecryptionSygicButton()).DecryptionReuslt.ToString();
                    CheckSygicButton = SBDecryptResult.ToString();

                    if (SBDecryptResult == CheckSygicButton)
                    {
                        SygicTruck_B.Enabled = true;
                    }
                }
                //Провіряємо другу кнопку
                string PocketInfopath1path = @"Data\\PocketInfopath1.data";
                var PocketInfopath1flen = new FileInfo(PocketInfopath1path).Length;
                if (PocketInfopath1flen != 0)
                { 
                    DecryptionIGONButton DecryptIGONButton = new DecryptionIGONButton();

                string IGONDecryptResult = (new DecryptionIGONButton()).DecryptionReuslt.ToString();
                CheckIGONButton = IGONDecryptResult.ToString();
                if (IGONDecryptResult == CheckIGONButton)
                {
                    IGONextgen_B.Enabled = true;
                }
                }
                //Провіряємо третю кнопку
                string PocketInfopath2path = @"Data\\PocketInfopath2.data";
                var PocketInfopath2flen = new FileInfo(PocketInfopath2path).Length;
                if (PocketInfopath2flen != 0)
                { 
                    DecryptionIGOPButton DecryptIGOPButton = new DecryptionIGOPButton();

                string IGOPDecryptResult = (new DecryptionIGOPButton()).DecryptionReuslt.ToString();
                CheckIGOPButton = IGOPDecryptResult.ToString();

                if (IGOPDecryptResult == CheckIGOPButton)
                {
                    IGOPrimo_B.Enabled = true;
                }
                }
                //Якщо всі кнопки після активації ключа стають активні, забираємо можливість в користувача активувати програму
                if (SygicTruck_B.Enabled == true && IGONextgen_B.Enabled == true && IGOPrimo_B.Enabled == true && Navitel_B.Enabled == true)
                {
                    ActiveBtn.Enabled = false;
                }
            }
            else
            {
               ActivationStatus.Text = "Activate your key";
            }
        }
              
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IGONextgenForm f1 = new IGONextgenForm();
            f1.Show();
        }

        private void SygicTruck_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            SygicTruckForm f1 = new SygicTruckForm();
            f1.Show();
        }

        private void IGOPrimo_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            IGOPrimoForm f1 = new IGOPrimoForm();
            f1.Show();
        }

        private void Navitel_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            NavitelForm f1 = new NavitelForm();
            f1.Show();
        }

        private void Exit_Program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/OL.Navigation");
        }

        private void Addition_B_Click(object sender, EventArgs e)
        {
            ActivationPanel.Visible = false;
            InfoPanel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Setings_B_Click(object sender, EventArgs e)
        {
            ActivationPanel.Visible = false;
            if (InfoPanel.Visible == false)
                InfoPanel.Visible = true;
            else
                InfoPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            if (ActivationPanel.Visible == false)
                ActivationPanel.Visible = true;
            else
                ActivationPanel.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Creators f1 = new Creators();
            f1.Show();
        }

        private void HideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Аналогічна функція, яка описана на "Form Load"
            string Key = Clipboard.GetText();
            string[] split = Key.Split(new Char[] { '-' });

            foreach (string s in split)
            {
                if (split.Length == 4)
                {
                    ActivKod.Text = split[0];
                    ActivKod1.Text = split[1];
                    ActivKod2.Text = split[2];
                    ActivKod3.Text = split[3];
                    EncryptionProvaider = Key;
                }
                else
                {
                    MessageBox.Show("Помилка активації ключа!");
                }
            }
        }
        private void ActiveBtn_Click(object sender, EventArgs e)
        {
            //Кнопка активації програми

            //Змінні призначенні для задання значення статуса кнопки для подальшого запису інформації в файл ".data" вразі якщо в веденому ключі є інформація про їхню активацію
            string NewSBEncrypt = "true";
            string NewIGONEncrypt = "true";
            string NewIGOPEncrypt = "true";
            string NewNEncrypt = "true";
            
            string tbS = ActivKod.Text;
            string tbIN = ActivKod1.Text;
            string tbIP = ActivKod2.Text;
            string tbNT = ActivKod3.Text;
            char[] ar_tbS = tbS.ToCharArray();
            char[] ar_tbIN = tbIN.ToCharArray();
            char[] ar_tbIP = tbIP.ToCharArray();
            char[] ar_tbNT = tbNT.ToCharArray();
            //Робимо провірку ключа
            if (ar_tbS[3] == 78)//Якщо n символ ключа відповідає певному символу то відкриваємо доступ до кнопки та передаємо інформацію про активацію
            {
                SygicTruck_B.Enabled = true;
                EncryptionSygicButton EncryptSygicButton = new EncryptionSygicButton(NewSBEncrypt);
            }
          
            if (ar_tbIN[3] == 69)
            {
                IGONextgen_B.Enabled = true;
                EncryptionIGONButton EncryptIGONButton = new EncryptionIGONButton(NewIGONEncrypt);
            }
           
            if (ar_tbIP[3] == 75)
            {
                IGOPrimo_B.Enabled = true;
                EncryptionIGOPButton EncryptIGOPButton = new EncryptionIGOPButton(NewIGOPEncrypt);
            }
           
            if (ar_tbNT[3] == 65)
            {
                Navitel_B.Enabled = true;
                EncryptionNavitelButton EncryptNavitel = new EncryptionNavitelButton(NewNEncrypt);
            }
           
            if (SygicTruck_B.Enabled == true && IGONextgen_B.Enabled == true && IGOPrimo_B.Enabled == true && Navitel_B.Enabled == true)
            {
                ActiveBtn.Enabled = false;
            }
            Encryption Encryption = new Encryption(EncryptionProvaider);//Закодовуємо інформацію про ключ
            ActivationPanel.Hide();
        }

        private void ActivationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActivKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string Key = Clipboard.GetText();
                string[] split = Key.Split(new Char[] { '-' });

                foreach (string s in split)
                {
                    if (split.Length == 4)
                    {
                        ActivKod.Text = split[0];
                        ActivKod1.Text = split[1];
                        ActivKod2.Text = split[2];
                        ActivKod3.Text = split[3];
                        EncryptionProvaider = Key;
                    }
                    else
                    {
                        MessageBox.Show("Помилка активації ключа!");
                    }
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
                ActivKod.Clear();
                ActivKod1.Clear();
                ActivKod2.Clear();
                ActivKod3.Clear();
        }
    }
}
