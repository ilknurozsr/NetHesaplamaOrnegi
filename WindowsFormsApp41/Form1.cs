using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double trDogru, trYanlis, trNet; // türkçe dersi için kullanacağımız değişkenleri tanımlıyoruz.
            double matDogru, matYanlis, matNet; // matematik dersi için kullanacağımız değişkenleri tanımlıyoruz.
            double fizDogru, fizYanlis, fizNet; // fizik dersi için kullanacağımız değişkenleri tanımlıyoruz.

            trDogru = Convert.ToInt32(txttrdogru.Text); // Doğru sayısını gireceğimiz textBox'ın text'ini yani sayımızı convert edip trDogru değişkenimize atıyoruz.
            trYanlis = Convert.ToInt32(txttryanlis.Text); // Yanlış sayısını gireceğimiz textBox'ın text'ini yani sayımızı convert edip trYanlis değişkenimize atıyoruz.

            matDogru = Convert.ToInt32(txtmatdogru.Text); // Doğru sayısını gireceğimiz textBox'ın text'ini yani sayımızı convert edip matDogru değişkenimize atıyoruz.
            matYanlis = Convert.ToInt32(txtmatyanlis.Text); // Yanlış sayısını gireceğimiz textBox'ın text'ini yani sayımızı convert edip matYanlis değişkenimize atıyoruz.

            fizDogru = Convert.ToInt32(txtfzdgru.Text); // Doğru sayısını gireceğimiz textBox'ın text'ini yani sayımızı convert edip fizDogru değişkenimize atıyoruz.
            fizYanlis = Convert.ToInt32(txtfzyanlis.Text); // Yanlış sayısını gireceğimiz textBox'ın text'ini yani sayımızı convert edip fizYanlis değişkenimize atıyoruz.

            trNet = trDogru - (trYanlis / 4); // Matematiksel olarak net hesabımızı yapıp trNet değişkenimize atıyoruz.
            matNet = matDogru - (matYanlis / 4); // Matematiksel olarak net hesabımızı yapıp matNet değişkenimize atıyoruz.
            fizNet = fizDogru - (fizYanlis / 4); // Matematiksel olarak net hesabımızı yapıp fizNet değişkenimize atıyoruz.

            txttrnet.Text = trNet.ToString(); // Net sayımızı attığımız değişkenimizi ilgili textBox'ına atıyoruz.
            txtmatnet.Text = matNet.ToString();
            txtfznet.Text = fizNet.ToString();
        }
    }
}
