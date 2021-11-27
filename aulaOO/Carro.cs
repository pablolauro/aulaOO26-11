using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Carro
    {
        private string _modelo;
        private string _cor;
        private int _ano;
        private string _marca;
        private string _chassi;
        private string _proprietario;
        private int _velocidademax;
        private int _velociadadeatual;
        private int _nrportas;
        private bool _temtetosolar;
        private int _nrmarchas;
        private bool _temcambioautomatico;
        private float _volumecombustivel;
        private int _marchaAtual;

        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public string marca { get; set; }
        public string chassi { get; set; }
        public string proprietario { get; set; }
        public int velocidademax { get; set; }
        public int velociadadeatual { get; set; }
        public int nrportas { get; set; }
        public bool temtetosolar { get; set; }
        public int nrmarchas { get; set; }
        public bool temcambioautomatico { get; set; }
        public float volumecombustivel { get; set; }

        public int marchaAtual { get; set; }


        public void acelera()
        {
            if (velociadadeatual <= velocidademax)
                velociadadeatual++; 
        }

        public void freiar()
        {
            velociadadeatual = 0;
        }

        public void trocarMarcha()
        {
            if (marchaAtual <= nrmarchas)
                marchaAtual++;
        }

        public void reduzMarcha()
        {
            if (marchaAtual <= nrmarchas)
                marchaAtual--;
        }

        public void novoMotor()
        {
            Motor m = new Motor();

            m.nomeFabricante = "Fiat";
            m.potencia = 85;
            m.tipo = "1.0";

            Console.WriteLine("Fabricante "+m.nomeFabricante);
            Console.WriteLine("PontÊncia " + m.potencia);
            Console.WriteLine("Tipo " + m.tipo);

        }
    }
}
