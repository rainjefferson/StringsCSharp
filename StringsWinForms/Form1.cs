using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringsWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "Este texto é do tipo alfanumerico e contem numeros e caracteres.";

            if (texto.Contains("numeros"))
            {
                
                label1.Text = "A frase contém a literal numeros. Posição: " + texto.IndexOf("numeros");
                label1.Text = label1.Text.ToUpper();
            }
            else
            {
                
                label1.Text = "A frase NÃO contém a literal numeros";
                label1.Text = label1.Text.ToLower();

            }
            // insert de string
            string meunome = "Rain";
            label2.Text = meunome.Insert(0, "Jefferson ");
            label2.Text += " - Substring: " + label2.Text.Substring(3, 4);


            // Testando o Split
            string nomes = "jefferson rafaela creni otilia_margarida_sara pedro lucas patricia ana";

            char[] separador = { ' ' };

            string[] resultado = nomes.Split(separador);

            foreach (string nome in resultado)
            {
                label3.Text += nome + "\n";
            }

            char[] separador2 = { ' ', '_' };

            string[] resultado2 = nomes.Split(separador);

            foreach (string nome in resultado2)
            {
                label3.Text += nome + "\n";
            }

            // StartWith e EndsWith

            if (nomes.StartsWith("je", StringComparison.OrdinalIgnoreCase))
            {
                label3.Text += "\n começa com je";
            }

            if (nomes.EndsWith("ana", StringComparison.OrdinalIgnoreCase))
            {
                label3.Text += "\n termina com ana";
            }

            // CompareTo e Equals
            string time = "Palmeiras";

            if (time.Equals("Palmeiras"))
            {
                label3.Text += "\n é palmeiras";
            }

            // Compara duas strings com ordem alfabetica
            // retorna 1 se a variavél seq2 tiver em ordem anterior da seq1
            // retorna 0 se tiver na mesma ordem
            // retorna -1 se a sequência for depois.

            string seq1 = "abc";
            string seq2 = "lmnop";

            label3.Text += "\n" + seq2.CompareTo(seq1);

            // Format

            decimal valor = 19.9876m;
            int temperatura = 27;
            // formatação é o indice, e numero de decimais, se for C transforma em moeda
            label4.Text = String.Format("o valor é {0:C6} e temperatura {1:N2}", valor, temperatura);

            // Data e hora: d,t: data e hora abreviada, D,T: Data e Hora completa
            label4.Text += "\n" +  String.Format("a data é {0:d} e são {0:t}", DateTime.Now);
            label4.Text += "\n" + String.Format("a data é {0:D} e são {0:T}", DateTime.Now);

            // outro jeito de formatar
            label4.Text += "\n" + $"o valor é {valor:C5} e temperatura {temperatura:N3}";

        }
    }
}
