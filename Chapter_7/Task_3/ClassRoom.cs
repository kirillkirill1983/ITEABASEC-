using System;

namespace Task_2
{
    public class ClassRoom
    {
        //private Pupil[] pupils;
        public Pupil[] Pupils { get; set; }
        //{
        //    get { return pupils; }
        //    set { pupils = value; }
        //}
        public ClassRoom(Pupil[] pupils)
        {
            this.Pupils =pupils;
        }
        public void Info(Pupil pupil)
        {
            //switch (pupil)
            //{
            //    case BadPupil badPupi:
            //        badPupi.Relax();
            //        badPupi.Read();
            //        badPupi.Study();
            //        badPupi.Write();
            //        break;
            //    default:
            //        break;
            //}

            if (pupil is BadPupil badPupi)
            {
                BadPupil badPupil = (BadPupil)pupil;
                badPupil.Read();
                badPupil.Relax();
                badPupil.Study();
                badPupil.Write();
            }
            else if (pupil is GoodPupil)
            {
                GoodPupil goodPupil = (GoodPupil)pupil;
                goodPupil.Read();
                goodPupil.Relax();
                goodPupil.Study();
                goodPupil.Write();
            }
            else if (pupil is ExcelentPupil)
            {
                ExcelentPupil excelentPupil = (ExcelentPupil)pupil;
                excelentPupil.Read();
                excelentPupil.Read();
                excelentPupil.Study();
                excelentPupil.Write();
            }
            else
                Console.WriteLine("Ошибка типа ввода скорее всего NULL");

        }
        
    }
}
