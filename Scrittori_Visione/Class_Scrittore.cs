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




        public Class_Scrittore(string nome, string colore, int stile, string nickname)
        {

            _colore = colore;   
            _stile = stile; 
            _nickname = nickname;

        }



        private string Colore
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

        private int Stile
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
        private string Nickname
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



    }
   

}
