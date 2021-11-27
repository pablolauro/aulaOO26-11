using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Pessoa
    {
        protected string nome;
        protected int idade;
        protected string genero;
        protected int altura;
        protected float peso;

        public Pessoa(string nome, int idade,string genero,int altura, float peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
            this.altura = altura;
            this.peso = peso;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void MostrarPessoa()
        {
            Console.WriteLine("Nome "+nome);
            Console.WriteLine("Idade "+idade);
        }
    }
}
