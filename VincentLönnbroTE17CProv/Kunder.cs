using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VincentLönnbroTE17CProv
{
    class Kunder
    {
        public string intresse;
        public int money;
        private int knowledge;

        private Random rnd;
        public Kunder()
        {
            money = rnd.Next(50, 250);
            knowledge = rnd.Next(1, 6);
        }
    }
}
