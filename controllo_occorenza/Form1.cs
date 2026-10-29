using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btn_verifica_Click(object sender, EventArgs e)
        {
            string risultato= " ", alfabeto= "abcdefghijklmnopqrstuvwxyz", frase=txt_n1.Text;
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
                risultato += alfabeto[i] + " " + contaLettere + "\n";
            }
            lbl_n2.Text = risultato;

        }              
    }
}
