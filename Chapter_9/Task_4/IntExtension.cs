using System;


namespace Task_4
{
    public static class IntExtension
    {
        public static int[] IntSort(this int[] temp) 
        {
           
            int count = 0;
           
            for (int i = 0; i < temp.Length - 1; i++)
            {
                for (int j = i + 1; j < temp.Length; j++)
                {
                    if (temp[i] > temp[j])
                    {
                        count = temp[i];
                        temp[i] = temp[j];
                        temp[j] = count;
                    }
                }
            }
            return temp;
        }

        public static int[] IntRandom(int value) 
        {
            Random random = new Random();
            int[] temp = new int[value];
            
            for (int i = 0; i < value; i++)
            {
                temp[i]= random.Next(10);
            }
            return temp;
        }
    }

}
