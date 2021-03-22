using System;


namespace Task_2
{
    class GoodPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("GoodPupil Read");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil Relax ");
        }
        public override void Study()
        {
            Console.WriteLine("GoodPupil Studyd");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil Write");
        }
    }
}
