using System;


namespace Task_3
{
    public static class StringExtension
    {
        public static int StrCount(this string valueStr,int valueLen ) 
        {
            int count = 0;
            for (int i = valueLen; i < valueStr.Length; i++)
            {
                count++;
            }
            return count;
           
        }
    }
}
