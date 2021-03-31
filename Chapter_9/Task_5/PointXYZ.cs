using System;


namespace Task_5
{
    public class PointXYZ
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public PointXYZ(int pX,int pY,int pZ )
        {
            X = pX;
            Y = pY;
            Z = pZ;
        }

        public static PointXYZ operator + (PointXYZ point1,PointXYZ point2) 
        {
            return new PointXYZ(point1.X + point2.X,point1.Y+point2.Y,point1.Z+point2.Z);   
        }

        public static PointXYZ operator -(PointXYZ point1, PointXYZ point2)
        {
            return new PointXYZ(point1.X - point2.X, point1.Y - point2.Y, point1.Z - point2.Z);
        }

        public static PointXYZ operator *(PointXYZ point1, PointXYZ point2)
        {
            return new PointXYZ(point1.X * point2.X, point1.Y * point2.Y, point1.Z * point2.Z);
        }

        public static PointXYZ operator /(PointXYZ point1, PointXYZ point2)
        {
            
            return new PointXYZ(point1.X/point2.Y , point1.Y / point2.Y, point1.Z / point2.Z);
        }

        public override string ToString()
        {
            return String.Format($"{this.X} : {this.Y} : {this.Z} "); 
        }

        public override bool Equals(object o)
        {
            if (o is PointXYZ)
            {
                if (((PointXYZ)o).X == this.X && ((PointXYZ)o).Y == this.Y && ((PointXYZ)o).Z == this.Z  )
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
