using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MotorGrafico
{
    public class Triangle:Figure
    {
        private static Point3D camera = new Point3D(0,0,1);
        private Point3D flatVector;
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
        public Point3D getCentroid()
        {
            return centroid;
        }
        public override void projection() {
            List<PointF> points2D = project();
            if(points2D!=null && points2D.Count!=0)
            Form1.graphics.DrawPolygon(new Pen(color),points2D.ToArray());
            
        }
        private List<PointF> project() {
            List<PointF> points2D = new List<PointF>();
            for(int i = 0; i<points.Count; i++)
            {
                Point3D point = points[i];
                flatVector = GetPlaneVector();
                float po = (float)Math.Sqrt(flatVector.dotProduct(camera));
                
                if (flatVector.getZ() / po > 0)
                {
                    PointF pointC = new PointF((point.getX() * 250 / (1 - +point.getZ())), (point.getY() * 250 / (1 - +point.getZ())));
                    pointC.X = pointC.X + Form1.center.X;
                    pointC.Y = Form1.center.Y - pointC.Y;
                    points2D.Add(pointC);
                }
                



            }
            return points2D;
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
        public Point3D GetPlaneVector()
        {
            // Get two sides of the triangle
            Point3D side1 = new Point3D(points[1].getX() - points[0].getX(), points[1].getY() - points[0].getY(), points[1].getZ() - points[0].getZ());
            Point3D side2 = new Point3D(points[2].getX() - points[0].getX(), points[2].getY() - points[0].getY(), points[2].getZ() - points[0].getZ());

            // Calculate the cross product of the two sides
            
            Point3D planeVector = Point3D.CrossProduct(side1, side2);

            return planeVector;
        }
    }
}
