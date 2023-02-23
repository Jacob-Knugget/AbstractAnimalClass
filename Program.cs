using System;
using System.Xml.Linq;

namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class Bear : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public double Weight { get; set; }
            public string Color { get; set; }

            public Bear()
            {
                Name = string.Empty;
                Weight = 0;
                Color = string.Empty;
            }
            public Bear(string name, double weight, string color)
            {
                Name = name;
                Weight = weight;
                Color = color;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a bear \nMy name is " + Name + "\nI am " + Color + "\nI am " + Weight + " pounds";
            }

        }
        static void Main(string[] args)
        {
            Bear grunt = new Bear("Grunt", 300, "white");
            Bear sneeze = new Bear();
            sneeze.Name = "Sneeze";
            sneeze.Weight = 120;
            sneeze.Color = "brown";
            Console.WriteLine(grunt.whatAmI());
            Console.WriteLine(grunt.Describe());
            Console.WriteLine(sneeze.whatAmI());
            Console.WriteLine(sneeze.Describe());
        }
    }
}