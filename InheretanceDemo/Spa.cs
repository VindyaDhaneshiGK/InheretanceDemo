using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceDemo
{
    public  class Spa: Pool
    {
        public int heatLevel;
        public Spa(int chlorine, int water, int heat) : base(chlorine, water)
        {
            heatLevel = heat;
        }
        public void SpaInfo()
        {
            Console.WriteLine($"Spa: {chlorineLevel}, {waterLevel}, {heatLevel}");
        }

    }
}
