using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Lampada
    {
        private string estadoLamp;
        public void ligar()
        {
            Console.WriteLine("Ligando Lampada");
            estadoLamp = "Ligada";
        }
        public void desligar()
        {
            Console.WriteLine("Desligando Lampada");
            estadoLamp = "Desligada";
        }

        public void meiaLuz()
        {
            Console.WriteLine("Meia Luz");
            estadoLamp = "Meia Luz";
        }

        public string estaLigada() 
        {
            return estadoLamp;
        }
    }
}
