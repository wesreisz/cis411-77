using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Animal
    {
        protected static int count;
        public String Name { get; set; }
        public String itemNumber { get; set; }

        public Animal() {
            count++;        
        }

        public override string ToString()
        {
            String result = Name + " (" + itemNumber + ") :: count: " + count;
            return result;
        }

    }
}
