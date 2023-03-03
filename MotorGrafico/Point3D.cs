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
        public static Point3D CrossProduct(Point3D a, Point3D b)
        {
            float x = a.getY() * b.getZ() - a.getZ() * b.getY();
            float y = a.getZ() * b.getX() - a.getX() * b.getZ();
            float z = a.getX() * b.getY() - a.getY() * b.getX();
            Point3D point = new Point3D(x, y, z);
            point.Normalize();
            return point;
            
        }
        public float dotProduct(Point3D other)
        {
            return this.getX() * other.getX() + this.getY() * other.getY() + this.getZ() * other.getZ();
        }
        private void Normalize() {
            
                float magnitude = (float)Math.Sqrt(coordinates[0] * coordinates[0] + coordinates[1] * coordinates[1] + coordinates[2] * coordinates[2]);

            if (magnitude == 0)
            {
                //throw new DivideByZeroException("Cannot normalize a zero vector.");
            }
            else {
                coordinates[0] /= magnitude;
                coordinates[1] /= magnitude;
                coordinates[2] /= magnitude;
            }

                
            
        }
    }
    
}
