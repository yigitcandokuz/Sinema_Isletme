using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private const string dosyaYolu = "veriler.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            List<string> secilenSaatler = new List<string>();

            if (checkBox1.Checked)
            {
                secilenSaatler.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                secilenSaatler.Add(checkBox2.Text);
            }
            if (checkBox3.Checked)
            {
                secilenSaatler.Add(checkBox3.Text);
            }
            if (checkBox4.Checked)
            {
                secilenSaatler.Add(checkBox4.Text);
            }
            
            if (secilenSaatler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir saat seçin.");
                return;
            }

            
            string filmAdi = textBox1.Text; 
            string salonAdi = "";

            if (radioButton1.Checked)
            {
                salonAdi = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                salonAdi = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                salonAdi = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                salonAdi = radioButton4.Text;
            }
            
            if (salonAdi == "")
            {
                MessageBox.Show("Lütfen bir salon seçin.");
                return;
            }


           
            using (StreamWriter sw = File.AppendText(dosyaYolu))
            {
                sw.WriteLine($"{filmAdi}, {salonAdi}, {secilenSaatler}"); 
            }

           
            MessageBox.Show("Veriler dosyaya başarıyla eklendi.");

            
            foreach (string saat in secilenSaatler)
            {
                dataGridView1.Rows.Add(filmAdi, salonAdi, saat);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
