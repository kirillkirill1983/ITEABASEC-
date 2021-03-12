using System;


namespace Task_2
{
    class Cat
    {
        private string name;
        private int age;
        private string colorEye;
        private string colorCoat;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string ColorEye
        {
            set { colorEye = value; }
            get { return colorEye; }
        }
        public string ColorCoat 
        {
            set { colorCoat = value; }
            get { return colorCoat; }
        }

        public void BeepCat(int variable)
        {
            Console.WriteLine($" Буль буль {variable} раз");
            for (int i = 0; i < variable; i++)
            {
                Console.WriteLine($"{colorEye} Пиво пиВо пИвО {colorCoat}");
            }
        }
    }
}
