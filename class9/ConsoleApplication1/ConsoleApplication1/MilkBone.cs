using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MilkBone : IBone
    { 
        private String _description = "I'm a delicious Milkbone";
        public String Name { get; set; }

        public string Description
        {
            get
            {
               return _description;
            }

           
        }
    }
}
