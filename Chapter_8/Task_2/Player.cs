using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Player : IPlayable, IRecodable
    {
        void IPlayable.Pause() 
        {
            Console.WriteLine("Pause");
        }
        void IPlayable.Play() 
        {
            Console.WriteLine("Play");
        }
        void IPlayable.Stop() 
        {
            Console.WriteLine("Stop");
        }

        void IRecodable.Pause() 
        {
            Console.WriteLine("Pause");
        }
        void IRecodable.Record() 
        {
            Console.WriteLine("Record");
        }
        void IRecodable.Stop() 
        {
            Console.WriteLine("Stop");
        }
    }
}
