using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Dog : Animal
    {
        public IBone MyBone { get; set; }

        public override string ToString()
        {
            String result = Name + " (" + itemNumber + ") :: count: " + count + " :: Thing Description: " + MyBone.Description;
            return result;
        }

    }
}
