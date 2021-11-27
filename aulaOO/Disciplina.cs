using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Disciplina
    {
        private string nome;
        private int cargahoraria;

        public Disciplina(string nome, int cargahoraria)
        {
            this.nome = nome;
            this.cargahoraria = cargahoraria;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome Disciplina "+this.nome);
            Console.WriteLine("Carga Horária "+this.cargahoraria);
        }
    }
}
