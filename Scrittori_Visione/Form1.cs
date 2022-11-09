using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Scrittori_Visione
{
    public partial class Form1 : Form
    {
 
  
        private Font font;

        private Class_Scrittore src;
        private Class_Visualizzatore vis;

       
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void butn_aggiungi_Click(object sender, EventArgs e)
        {
            scrivi_Click();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            src = new  Class_Scrittore(vis);
        }

        private void scrivi_Click()
        {
            

            if (textBox_Nick.Text != "" && comboBox_Colore.Text != "" && textBox1.Text != "")
            {
                src.Nickname = textBox_Nick.Text;
                
                FontStyle f;
                //riferimento al testo selezionato
                font = richTextBox1.SelectionFont;
                if (font != null)
                {
                    f = font.Style;
                    //controllo stili selezionati
                    if (checkBox_grassetto.Checked)
                        f ^= FontStyle.Bold;
                    if (checkBox_corsivo.Checked)
                        f ^= FontStyle.Italic;
                    if (checkBox_sottolineato.Checked)
                        f ^= FontStyle.Underline;
                    //setta lo stile del font
                    richTextBox1.SelectionFont = new Font(font, f);
                }
                //setta il colore
                if (comboBox_Colore.Text == "ROSSO")
                {
                    richTextBox1.SelectionColor = Color.Red;
                }
                if (comboBox_Colore.Text == "VERDE")
                {
                    richTextBox1.SelectionColor = Color.Green;
                }
                if (comboBox_Colore.Text == "BLU")
                {
                    richTextBox1.SelectionColor = Color.Blue;
                }
                src.Testo = textBox1.Text;

                //aggiunge il testo applicando stile e colore
                richTextBox1.AppendText(src.Nickname + ": " + src.Testo + "\n");
            }
            else 
            MessageBox.Show("Compilare tutti i campi");

        }


    


 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nick_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
