using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Dog:Tailedanimal
    {
        private string name;
        public string Name 
        {
            get { return name;}
            set { name = value; }
        }

        public Dog(Tail valuetail, string valuecolor, int valueage,string valuename) :base(valuetail,valuecolor, valueage)
        {
            name = valuename;
        }

        public void Info() 
        {
            Console.WriteLine($" длина хвоста =>{this.Tail.Length} " +
                $"вид хвоста =>{this.Tail.Type} " +
                $"цвет= >{this.Color} " +
                $"возраст = >{this.Age} " +
                $"кличка => {this.Name} ");
        }

    }
}
