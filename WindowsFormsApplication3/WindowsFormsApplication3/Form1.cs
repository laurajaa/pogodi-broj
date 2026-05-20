using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int trazeniBroj;
        int brojPokusaja = 0;

        public Form1()
        {
            InitializeComponent();

            // nasumičan broj od 1 do 100
            trazeniBroj = rnd.Next(1, 101);

            // kada se pritisne Enter u textboxu
            textBox1.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int unetBroj;

                // proverava da li je unet broj
                if (int.TryParse(textBox1.Text, out unetBroj))
                {
                    brojPokusaja++;

                    BrPokusaja.Text = brojPokusaja.ToString();

                    if (unetBroj < trazeniBroj)
                    {
                        Komentar.Text = "Broj je veći!";
                    }
                    else if (unetBroj > trazeniBroj)
                    {
                        Komentar.Text = "Broj je manji!";
                    }
                    else
                    {
                        Komentar.Text = "Pogodili ste broj!";
                        MessageBox.Show("Bravo! Pogodili ste broj za " +
                        brojPokusaja + " pokušaja.");
                    }

                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Unesite ispravan broj!");
                }
            }
        }
    }
}