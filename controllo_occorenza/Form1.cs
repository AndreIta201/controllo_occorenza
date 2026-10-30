using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controllo_occorenza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        private void btn_verifica_Click(object sender, EventArgs e)
        {
            string risultato= " ", frase=txt_n1.Text;
            int contaLettere = 0;
           
            for (int i = 0; i<alfabeto.Length; i++)
            {
                contaLettere = 0;
                for (int j = 0; j < frase.Length; j++)
                {
                    if (alfabeto[i] == frase[j])
                    {
                        contaLettere++;
                    }

                }
                risultato += alfabeto[i] + ": " + contaLettere + "\n";
            }
            lbl_n2.Text = risultato;

        }

        private void btn_cerca_Click(object sender, EventArgs e)
        {

            string parola = txt_n1.Text;
            string input = txt_n2.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Inserisci una lettera da cercare.");
                return;
            }
           
            char letteraCercata = input[0];
        
            int conteggio = parola.Count(c => char.ToLower(c) == char.ToLower(letteraCercata));

            if (conteggio > 0)
            {
                MessageBox.Show($"La lettera '{letteraCercata}' è contenuta {conteggio} volt{(conteggio == 1 ? "a" : "e")} nella parola!");
            }
            else
            {
                MessageBox.Show($"La lettera '{letteraCercata}' non è presente nella parola.");
            }

        }
    }
}
