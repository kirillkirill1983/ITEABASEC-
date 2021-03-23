using System;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Play or Recodr");
            string movePlay = Convert.ToString(Console.ReadLine());
            Console.WriteLine(new string('=', 10));
            switch (movePlay)
            {
                case "Play":
                    IPlayable playable = player;// можно дальше развить линию выбора ченго именно хочет душа 
                    playable.Play();
                    playable.Pause();
                    playable.Stop();
                    break;
                case "Record":
                    IRecodable recodable = player;
                    recodable.Pause();
                    recodable.Stop();
                    recodable.Record();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
            Console.ReadKey();
        }
    }
}
