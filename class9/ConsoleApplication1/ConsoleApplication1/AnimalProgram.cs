using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AnimalProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Dog widget1 = new Dog();
            widget1.Name = "test";
            widget1.itemNumber = "#453";
            IBone bone = new MilkBone();
            bone.Name = "A Name";
            widget1.MyBone = bone;
            Console.WriteLine(widget1);

            Dog widget2 = new Dog();
            IBone bone1 = new PeanutButtonBone();
            bone1.Name = "Peanut Butturrr";
            widget2.MyBone = bone1;
            widget2.Name = "stuff";
            widget2.itemNumber = "#5553";
            Console.WriteLine(widget2);
            
            Console.Read();
        }
    }
}
