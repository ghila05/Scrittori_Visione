using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // libreria per color dialog
using System.Drawing; // libreria per color dialog

namespace Scrittori_Visione
{
    public class Class_Visualizzatore
    {

        public bool grassetto;
        public bool corsivo;
        public bool sottolineato;
        public Color colore;
        private string text;

        public string Testo
        {
            set
            {
                text = value;
            }
            get
            {
                return text;
            }
        }

        public void Aggiugni(string iltext)
        {
            text += iltext;
        }



       
    }
}
