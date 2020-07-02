using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConparePrac
{

    class Prodect
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name + " : " + this.Price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
