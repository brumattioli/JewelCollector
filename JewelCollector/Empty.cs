using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelCollector
{
    internal class Empty : ICell
    {
        // Construtor da classe
        //public Empty() { }

        // Implementar a interface
        public string Print()
        {
            return " -- ";
        }
    }
}