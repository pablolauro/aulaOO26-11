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

        public string modelo { get => _modelo; set => _modelo = value; }
        public string cor { get => _cor; set => _cor = value; }
        public int ano { get => _ano; set => _ano = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string chassi { get => _chassi; set => _chassi = value; }
        public string proprietario { get => _proprietario; set => _proprietario = value; }
        public int velocidademax { get => _velocidademax; set => _velocidademax = value; }
        public int velociadadeatual { get => _velociadadeatual; set => _velociadadeatual = value; }
        public int nrportas { get => _nrportas; set => _nrportas = value; }
        public bool temtetosolar { get => _temtetosolar; set => _temtetosolar = value; }
        public int nrmarchas { get => _nrmarchas; set => _nrmarchas = value; }
        public bool temcambioautomatico { get => _temcambioautomatico; set => _temcambioautomatico = value; }
        public float volumecombustivel { get => _volumecombustivel; set=> _volumecombustivel = value; }

        public int marchaAtual { get => _marchaAtual; set => _marchaAtual = value; }


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
