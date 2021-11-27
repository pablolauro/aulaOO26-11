using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Motor
    {
        private string _nomeFabricante;
        private int _potencia;
        private string _tipo;

        //public Motor(string nomeFrabricante, int potencia, string tipo)
        //{
        //    this.nomeFabricante = nomeFrabricante;
        //    this.potencia = potencia;
        //    this.tipo = tipo;
        //}

        /* public void setnomeFrabricante(string nomeFabricante)
         {
             this._nomeFabricante = nomeFabricante;
         }

         public string getnomeFabricante()
         {
             return this._nomeFabricante;
         }*/


        public string nomeFabricante { get; set; }

        public int potencia
        {
            get
            {
                return _potencia;
            }
            set
            {
                _potencia = value;
            }
        }

        public string tipo
        {
            get
            {
                return _tipo;             
            }
            set
            {
                _tipo = value;
            }
        }

    }
}
