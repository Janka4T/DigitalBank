using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;

namespace DigitalBag
{
    class Human
    {
        public string EyeColor { get; }
        public decimal Height { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        private int a = 5;
        private int b = 10;

        public Human(string name, string surname, string eyeColor, decimal height)
        {
            this.EyeColor = eyeColor;
            this.Height = height;
            this.Name = name;
            this.Surname = surname;
            
        }

        public void AddNumbersFromMemory()
        {
            Console.WriteLine(a + b);
        }

        public void AddNumbers(decimal n1 , decimal n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public void SetHeight(decimal height)
        {
            if (height > 0)
            {
                this.Height = height;
            }
            else
            {
                Console.WriteLine("The Height must be Positive");
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi my Name is {this.Name} {this.Surname} im {this.Height} cm.");
        }
    }
}
