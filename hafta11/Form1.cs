using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            dataGridView1.DataSource = p.PersonelGetir();
        }

        private void labelAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.AdSoyad = textBoxAdSoyad.Text;
            p.Birim = textBoxBirim.Text;
            p.Maas = Convert.ToDouble(textBoxMaas.Text);
            p.GorevId = comboBox1.SelectedIndex + 1;
            bool kontrol = p.PersonelEkle(p);
            if (kontrol) //if(kontrol==true)
            {
                MessageBox.Show("Kayıt Eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Hata Oluştu.");
            }
            dataGridView1.DataSource = p.PersonelGetir();
            textBoxAdSoyad.Text = textBoxBirim.Text = textBoxMaas.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxBirim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxMaas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            int i = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            comboBox1.SelectedItem = comboBox1.Items[i - 1];
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.PersonelId = Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            bool kontrol = personel.DeletePersonel(personel);
            if (kontrol)
            {
                MessageBox.Show("İşlem başarılı");
            }
            else
            {
                MessageBox.Show("Bir hata oluştu");
            }
            dataGridView1.DataSource = personel.PersonelGetir();  //Verileri tekrar cektik.tabloyu güncelledik
            textBoxAdSoyad.Text = textBoxBirim.Text = textBoxMaas.Text = ""; //textboxları temizledik
        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.PersonelId =Convert.ToInt16 (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            p.AdSoyad = textBoxAdSoyad.Text;
            p.Birim = textBoxBirim.Text;
            p.Maas =Convert.ToDouble (textBoxMaas.Text);
            p.GorevId = comboBox1.SelectedIndex + 1;
            bool kontrol = p.UpdatePersonel(p);
            if (kontrol)
            {
                MessageBox.Show("Kayıt güncellendi.");
            }
            else
            {
                MessageBox.Show("İşlem başarısız.");
            }
            dataGridView1.DataSource = p.PersonelGetir(); //Verileri tekrar çektik. tebloyu güncelledik 
            textBoxAdSoyad.Text = textBoxBirim.Text = textBoxMaas.Text = ""; //textboxları temızledık
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
    }
}

