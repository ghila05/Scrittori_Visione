using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittori_Visione
{
    internal class Class_Visualizzatore
    {
   
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
