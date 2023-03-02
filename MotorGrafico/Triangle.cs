using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class Triangle:Figure
    {
        private Color color;
        private List<Point3D> points;
        public Triangle(Point3D p1, Point3D p2, Point3D p3, Color color) {
            this.color = color;
            points = new List<Point3D>();
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
        }
        public Triangle(Point3D p1, Point3D p2, Point3D p3)
        {
            this.color = Color.Green;
            points = new List<Point3D>();
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
        }
        public override void projection() {
            List<PointF> points2D = project(points);
            Form1.graphics.DrawPolygon(new Pen(color),points2D.ToArray());
        }
        public override void rotateX(float angle)
        {
            float radians = toRadians(angle);
            float cosAngle = (float)Math.Cos(radians);
            float sinAngle = (float)Math.Sin(radians);
            float[,] rotateMatrix = new float[,]{   {1,   0    ,    0    },
                                                    {0,cosAngle,-sinAngle},
                                                    {0,sinAngle, cosAngle}};
            

            for (int i = 0; i<points.Count(); i++)
            {
               points[i] = multiplyMatrix(points[i], rotateMatrix);
            }
           
        }
        public override void rotateY(float angle)
        {
            float radians = toRadians(angle);
            float cosAngle = (float)Math.Cos(radians);
            float sinAngle = (float)Math.Sin(radians);
            float[,] rotateMatrix = new float[,]{   { cosAngle,0,sinAngle},
                                                    {    0    ,1,    0   },
                                                    {-sinAngle,0,cosAngle}};


            for (int i = 0; i < points.Count(); i++)
            {
                points[i] = multiplyMatrix(points[i], rotateMatrix);
            }

        }
        public override void rotateZ(float angle)
        {
            float radians = toRadians(angle);
            float cosAngle = (float)Math.Cos(radians);
            float sinAngle = (float)Math.Sin(radians);
            float[,] rotateMatrix = new float[,]{   {cosAngle,-sinAngle,0},
                                                    {sinAngle,cosAngle ,0},
                                                    {   0    ,   0     ,1}};


            for (int i = 0; i < points.Count(); i++)
            {
                points[i] = multiplyMatrix(points[i], rotateMatrix);
            }

        }
        private Point3D multiplyMatrix(Point3D point, float[,] matrix)
        {
            float x = point.getX();
            float y = point.getY();
            float z = point.getZ();

            float newX = matrix[0, 0] * x + matrix[0, 1] * y + matrix[0, 2] * z;
            float newY = matrix[1, 0] * x + matrix[1, 1] * y + matrix[1, 2] * z;
            float newZ = matrix[2, 0] * x + matrix[2, 1] * y + matrix[2, 2] * z;

            return new Point3D(newX, newY, newZ);
        }
    }
}
