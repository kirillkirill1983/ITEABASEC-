using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Adress
    {
        private string country = string.Empty;
        private string city = string.Empty;
        private string street = string.Empty;
        private int house;
        private int apartment;
        private int index;

        public string Country
        {
            set  
            {
                country= value;
            }
            
            get  
            {
                return country;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }

            get
            {
                return city;
            }
        }
        public string Street
        {
            set
            {
                street =value;
            }

            get
            {
                return street;
            }
        }
        public int House
        {
            set
            {
                house = value;
            }

            get
            {
                return house;
            }
        }
        public int Apartment
        {
            set
            {
                apartment = value;
            }

            get
            {
                return apartment;
            }
        }

        public int Index
        {
            set
            {
                index = value;
            }

            get
            {
                return index;
            }
        }
        public void ShowAdress() 
        {
            Console.WriteLine($"{country} ,{city}, {street}," +
                $"{house}, {apartment}, {index} ");
        }

    }
}
