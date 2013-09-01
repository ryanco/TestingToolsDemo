using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTools
{
    public class IceCream
    {
        private string _name;


        public IceCream()
        {
        
        }

        public IceCream(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
