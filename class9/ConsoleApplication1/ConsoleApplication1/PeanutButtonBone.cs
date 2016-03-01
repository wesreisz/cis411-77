using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PeanutButtonBone : IBone
    {
        private String _description = "Yummy Peanut Buttur";
        public string Description
        { get { return _description; } }

        public string Name {get; set;}
    }
}
