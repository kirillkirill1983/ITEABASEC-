using System;


namespace Task_2
{
    public static class Convector
    {
        //private static int temperaureCelcium;

        //public static string TemperaureCelcium{ get; set; }

        public static void CelsiumToFahrenheit (string TemperaureCelcium) 
        {
            int temperaureCelcium = Convert.ToInt32(TemperaureCelcium);
            double Fahrenheit = (temperaureCelcium - 32) / 1.8;
            Console.WriteLine("Фаренгейт => {0}",String.Format("{0:f2}",Fahrenheit));
        }

        public static void FahrenheitToCelsium(string CelciumTemperaure) 
        {
            int temperaureFar = Convert.ToInt32(CelciumTemperaure);
            double Celcium = (temperaureFar - 32) * 0.55;
            Console.WriteLine("Цельсий => {0}",String.Format("{0:f2}", Celcium));
        }
    }
}
