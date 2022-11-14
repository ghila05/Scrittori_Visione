using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // libreria per color dialog
using System.Drawing; // libreria per color dialog

namespace Scrittori_Visione
{
    public class Class_Scrittore
    {

        string _colore;
        int _stile; //1- grassetto 2-corsivo  3-sottolineato
        string _nickname;
        string _testo;
        private Class_Visualizzatore visualizzatore;
        bool g;
        bool s;
        Color co;
        


        public Class_Scrittore(string nome, string colore, int stile, string nickname)
        {

            _colore = colore;   
            _stile = stile; 
            _nickname = nickname;

        }
        public Class_Scrittore(Class_Visualizzatore ilvisualizzatore)
        {
            visualizzatore = ilvisualizzatore;
        }
            
        public Color colore
        {
            get
            {
                return colore;
            }
            set
            {
                visualizzatore.colore = co;
            }
        }
        public bool Grassetto
        {
            get
            {
                return g;
            }
            set
            {
                visualizzatore.grassetto = g;
            }

        }

        public bool Sottolineato
        {
            get
            {
                return s;
            }
            set
            {
                visualizzatore.sottolineato = s;
            }

        }

        public void AggiungiText(string testo)
        {
            visualizzatore.Aggiugni(testo);
        }


        public string Colore
        {
            get
            {
                return _colore;
            }
            set
            {
                _colore = value;
            }

        }

        public int Stile
        {
            get
            {
                return _stile;
            }
            set
            {
                _stile = value;
            }

        }
        public  string Nickname
        {
            get
            {
                return _nickname;
            }
            set
            {
                _nickname = value;
            }

        }
        public string Testo
        {
            set
            {
                _testo = value;
            }

            get
            {
                return _testo;
            }
        }



    }
   

}
