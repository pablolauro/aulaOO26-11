using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Animal
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _peso;
        private bool _dormindo;

        public string nome { get => _nome; set => _nome = value; }
        public string sexo { get => _sexo; set => _sexo = value; }
        public string raca { get => _raca; set => _raca = value; }
        public string peso { get => _peso; set => _peso = value; }
        public bool dormindo { get => _dormindo; set => _dormindo = value; }

        public void emitirSom()
        {
            Console.WriteLine("Emitindo Som"); ;
        }

        public void dormir()
        {
            this.dormindo = true;
            Console.WriteLine("Dormindo"); ;
        }


        public void caminhar()
        {
            Console.WriteLine("Caminhando");
        }


    }
}
