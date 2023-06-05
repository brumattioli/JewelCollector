using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelCollector
{
    //A classe Robot deverá ser responsável por armazenar as informações do robô, 
    //que será a posição (x, y) e uma sacola (bag), em que o robô colocará as joias 
    //coletadas no mapa. Além disso, a classe Robot deverá implementar os métodos 
    //para que o robô possa interagir com o mapa, isto é, deslocar-se nas quatro 
    //direções e coletar as joias. Além disso, implemente um método para imprimir 
    //na tela o total de joias armazenadas na sacola e o valor total.

    internal class Robot
    {
        // Propriedades da classe
        public int PosicaoX;
        public int PosicaoY;
        public List<Jewel> Bag = new List<Jewel>();

        // Construtor da classe
        /*public Robot(int posicaoX, int posicaoY)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
            Bag = bag;
        }*/

        // Métodos da Classe

        string Print()
        {
            return "ME";
        }
    }
}
