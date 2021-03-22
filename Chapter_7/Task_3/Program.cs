using System;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil badPupil = new BadPupil();
            
            GoodPupil goodPupil = new GoodPupil();

            ExcelentPupil excelentPupil = new ExcelentPupil();

            Pupil[] pupils = new Pupil[5];

            pupils[0] = badPupil;
            pupils[1] = goodPupil;
            pupils[2] = badPupil;
            pupils[3] = excelentPupil;


            ClassRoom classRooms = new ClassRoom(pupils);

            foreach (var item in classRooms.Pupils)
            {
                classRooms.Info(item);
            }

            Console.ReadKey();
        }  
    }
}
