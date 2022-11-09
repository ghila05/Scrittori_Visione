using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrittori_Visione
{
    internal class Class_Scrittore
    {

        string _colore;
        int _stile; //1- grassetto 2-corsivo  3-sottolineato
        string _nickname;
        string _testo;
        private Class_Visualizzatore visualizzatore;



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
