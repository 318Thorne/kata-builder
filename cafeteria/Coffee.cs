using System;
using System.Collections.Generic;

namespace cafeteria
{
    public class Coffee
    {
        public string Sort;
        public List<Milk> Milk;
        public List<Sugar> Sugars;
        public Coffee()
        {
            Milk = new List<Milk>();
            Sugars = new List<Sugar>();
        }
    }
}