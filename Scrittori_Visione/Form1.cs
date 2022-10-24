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
        string Nickname;
        string Font;
        string Colore;
        string text;
        private Font font;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void butn_aggiungi_Click(object sender, EventArgs e)
        {
            scrivi_Click();

        }

        private void scrivi_Click()
        {
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
            if (comboBox_Colore.Text == "Rosso")
            {
                richTextBox1.SelectionColor = Color.Red;
            }
            if (comboBox_Colore.Text == "Verde")
            {
                richTextBox1.SelectionColor = Color.Green;
            }
            if (comboBox_Colore.Text == "Blu")
            {
                richTextBox1.SelectionColor = Color.Blue;
            }
            //aggiunge il testo applicando stile e colore
            richTextBox1.AppendText(textBox1.Text + "\n");

            text = textBox1.Text;

            richTextBox1.Text=(text);
        }


    



       






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
