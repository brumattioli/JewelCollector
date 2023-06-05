using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A classe Jewel deverá armazenar as informações da joia, como a posição (x, y) no mapa e o tipo, 
//que poderá ser Red, no valor de 100 pontos; Green, no valor de 50 pontos; e Blue, no valor de 10 pontos. 
namespace JewelCollector
{
    internal class Jewel : ICell
    {
        // Propriedades da classe
        public int PosicaoX; 
        public int PosicaoY; 
        public string Tipo;
        public int Valor;

        // Construtor da classe
        public Jewel(int posicaoX, int posicaoY, string tipo, int valor)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
            Tipo = tipo;
            Valor = valor;
        }

        // Implementar o método da interface
        public string Print()
        {
            System.Console.WriteLine(" JR ");
            return "fim";
        }
    }
}