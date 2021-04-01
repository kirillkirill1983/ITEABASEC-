using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public struct Notebbok
    {
        public string model;
        public string production;
        public int price;

        public Notebbok(string sMode, string sProduction, int sPrice)
        {
            this.model = sMode;
            this.production = sProduction;
            this.price = sPrice;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Prodcction
        {
            get { return production; }
            set { production = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public void Display()
        {
            Console.WriteLine($"{model} {production} {price}");
        }
    }
}
