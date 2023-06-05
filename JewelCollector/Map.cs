using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JewelCollector
{
    internal class Map
    {
        // Propriedades da classe
        public object[,] tab;

        //Métodos da classe:

        //Método para cima

        //Método para baixo

        //Método para direita

        //Método para a esquerda

        //Método para coletar jóia

        //Método total de joias armazenadas

        /*public int quantidadeJoias(List<Jewel> Bag)
        {
            int contagem = Bag.Count((item) =>
            {
                return item.Valor;
            });
            return contagem;
        }*/

        //Método valor total
        public int valorJoias(List<Jewel> Bag)
        {
            int total = Bag.Sum((item) =>
            {
                return item.Valor;
                Console.WriteLine(item.Valor.ToString());
            });
            return total;
        }
        //Método para inserir algo do mapa

        //Método para desenhar o mapa

        /*public int Criamapa((int x, int y)
        {
            object[,] matriz = 
            return matriz
        }*/
        //Método para ler posição no mapa
    }
}