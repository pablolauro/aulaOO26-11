using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaOO
{
    class Livro
    {
        
        protected string titulo;
        protected string editora;
        protected string autor;
        protected int ano;
        protected string genero;
        protected string isbn;

        public Livro(string titulo, string editora, string autor, int ano, string genero, string isbn)
        {
            this.titulo = titulo;
            this.editora = editora;
            this.autor = autor;
            this.ano = ano;
            this.genero = genero;
            this.isbn = isbn;
        }

        public void mostraTitulo()
        {
            Console.WriteLine(titulo);
        }


    }
}
