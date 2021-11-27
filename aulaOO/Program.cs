using System;

namespace aulaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Livro l = new Livro("Senhor dos aneis", "Terra média", "Tolkien", 1890, "Fantasia", "ABC1234567890");
            ///

            Carro c = new Carro();

            c.marca = "VolKsWagem";
            c.modelo = "Gol";
            c.nrmarchas = 5;
            c.nrportas = 4;
            c.temtetosolar = false;
            c.velocidademax = 5;
            
            c.trocarMarcha();
            Console.WriteLine("Marchar "+c.marchaAtual);
            c.trocarMarcha();
            Console.WriteLine("Marchar " + c.marchaAtual);

            c.reduzMarcha();
            Console.WriteLine("Marchar " + c.marchaAtual);

            c.acelera();
            c.acelera();
            c.acelera();
            Console.WriteLine("Velocidade "+c.velociadadeatual);

            c.freiar();
            Console.WriteLine("Velocidade " + c.velociadadeatual);



            //c.novoMotor();



        }


    }
}
