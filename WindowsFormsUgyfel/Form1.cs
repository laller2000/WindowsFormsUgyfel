using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsUgyfel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLista_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_Nev.Text.Trim()))
            {
                MessageBox.Show("Név megadéása kötelező", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Nev.Focus();
                return;
            }
            string nev = textBox_Nev.Text.Trim();
            if (comboBox_Beosztas.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon beosztást!");
                return;
            }
            string beosztas=comboBox_Beosztas.SelectedItem.ToString();
            int szulev=(int)numericUpDown_Szuletes.Value;
            string nem;
            if(radioButton_No.Checked)
            {
                nem = "no";
            }
            else if(radioButton_Ferfi.Checked)
            {
                nem = "ferfi";
            }
            else
            {
                nem="egyeb";
            }
            if (comboBox_Helyseg.SelectedIndex<0)
            {
                MessageBox.Show("Válasszon helységet!");
                return;
            }
            string helyseg=comboBox_Helyseg.SelectedItem.ToString();
            Ugyfel ugyfel = new Ugyfel(nev, beosztas, szulev, nem, helyseg);
            listBox_Dolgozok.Items.Add(ugyfel);
            textBox_Nev.Text = "";
            comboBox_Beosztas.SelectedIndex = -1;
            comboBox_Helyseg.SelectedIndex = -1;
            numericUpDown_Szuletes.Value = 1995;
        }

        private void btnFajlbair_Click(object sender, EventArgs e)
        {
            //adatok szövegjálba írása
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //meadta a mentéshez szükséges adatokat
                string fajl = saveFileDialog1.FileName;
                using (StreamWriter sw=new StreamWriter(fajl))
                {
                    foreach (Ugyfel item in listBox_Dolgozok.Items)
                    {
                        sw.WriteLine(item.Egysorba());
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK==openFileDialog1.ShowDialog())
            {
                using (StreamReader sr=new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        Ugyfel ugyfel = new Ugyfel(sr.ReadLine());
                        listBox_Dolgozok.Items.Add(ugyfel);
                    }
                }
            }
        }
    }
}
