using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelCollector
{
    internal class Obstacle : ICell
    {
        // Propriedades da classe
        public int PosicaoX;
        public int PosicaoY;
        public string Tipo;

        // Construtor da classe
        public Obstacle(int posicaoX, int posicaoY, string tipo)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
            Tipo = tipo;
        }

        // Métodos de instância
        public void PrintTree()
        {
            Console.WriteLine("$$");
        }
        public void PrintWater()
        {
            Console.WriteLine("##");
        }
        public string Print()
        {
            return " $$ ";
        }
    }
}
