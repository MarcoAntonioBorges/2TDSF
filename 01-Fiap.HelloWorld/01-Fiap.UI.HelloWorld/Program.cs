using _01_Fiap.UI.HelloWorld.Model;
using System;

namespace Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro();
            //Atribuir um código ao carro
            carro.Codigo = 10;
            //Exibir o código do carro
            Console.WriteLine(carro.Codigo);            
        }
    }
}
