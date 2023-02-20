using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class Point3D
    {
         private float[] coordinates;
        public Point3D(float X, float Y, float Z)
        {
            coordinates = new float[3];
            coordinates[0] = X;
            coordinates[1] = Y;
            coordinates[2] = Z;

        }
        public float getX()
        {
            return coordinates[0];
        }
        public void setX(float X) {
            coordinates[0] = X;
        }
        public float getY()
        {
            return coordinates[1];
        }
        public void setY(float Y)
        {
            coordinates[1] = Y;
        }
        public void setZ(float Z)
        {
            coordinates[2] = Z;
        }
        public float getZ()
        {
            return coordinates[2];
        }
        
    }
    
}
