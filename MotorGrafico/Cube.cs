using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class Cube  : Figure
    {
        private Face front;
        private Face back;



        public Cube(Point3D centroid, float lenght)
        {

            float number = lenght / 2;


            float z = 1;
            front = new Face();
            front.points.Add(new Point3D(centroid.getX() + number, centroid.getY() + number, centroid.getZ() +number ));
            front.points.Add(new Point3D(centroid.getX() + number, centroid.getY() - number,centroid.getZ() +number ));
            front.points.Add(new Point3D(centroid.getX() - number, centroid.getY() - number,centroid.getZ() + number  ));
            front.points.Add(new Point3D(centroid.getX() - number, centroid.getY() + number,centroid.getZ() + number  ));
            back = new Face();
            back.points.Add(new Point3D(centroid.getX() + number , centroid.getY() + number, centroid.getZ() - number));
            back.points.Add(new Point3D(centroid.getX() + number , centroid.getY() - number, centroid.getZ() - number));
            back.points.Add(new Point3D(centroid.getX() - number , centroid.getY() - number, centroid.getZ() - number));
            back.points.Add(new Point3D(centroid.getX() - number , centroid.getY() + number, centroid.getZ() - number));


        }
        public override void projection()
        {
            List<PointF> front2D = new List<PointF>();
            List<PointF> back2D = new List<PointF>();
            String text = "";
            foreach (Point3D point in front.points) {
                PointF pointC = new PointF((point.getX()*250 / (1- + point.getZ() )), (point.getY()*250 / (1- + point.getZ())));
                pointC.X = pointC.X + Form1.center.X;
                pointC.Y = Form1.center.Y - pointC.Y;
                front2D.Add(pointC);
                
            }
            
            Form1.graphics.DrawPolygon(Pens.White, front2D.ToArray());
            foreach (Point3D point in back.points)
            {

                PointF pointC = new PointF((point.getX()*250 / (1- +point.getZ())), (point.getY()*250 / (1- + point.getZ())));
                pointC.X = pointC.X + Form1.center.X;
                pointC.Y = Form1.center.Y - pointC.Y;
                back2D.Add(pointC);
                text += pointC.ToString();
            }
            Form1.graphics.DrawPolygon(Pens.White, back2D.ToArray());
            
            for (int i = 0; i < front2D.Count ; i++) {
                Form1.graphics.DrawLine(Pens.White, front2D[i], back2D[i]);
            }

        }
        public override void rotateZ(float angle)
        {
           float radians = toRadians(angle);
          foreach(Point3D point in front.points)
            {
                point.setX((float)(Math.Cos(radians)*point.getX()-Math.Sin(radians)*point.getY()));
                point.setY((float)(Math.Sin(radians) * point.getX() + Math.Cos(radians) * point.getY()));
            }
            foreach (Point3D point in back.points)
            {
                point.setX((float)(Math.Cos(radians) * point.getX() - Math.Sin(radians) * point.getY()));
                point.setY((float)(Math.Sin(radians) * point.getX() + Math.Cos(radians) * point.getY()));
            }
        }
        public override void rotateY(float angle) {
            float radians = toRadians(angle);
            foreach (Point3D point in front.points)
            {
                point.setX((float)(Math.Cos(radians) * point.getX() + Math.Sin(radians) * point.getZ()));
                point.setZ((float)(-Math.Sin(radians) * point.getX() + Math.Cos(radians) * point.getZ()));
            }
            foreach (Point3D point in back.points)
            {
                point.setX((float)(Math.Cos(radians) * point.getX() + Math.Sin(radians) * point.getZ()));
                point.setZ((float)(-Math.Sin(radians) * point.getX() + Math.Cos(radians) * point.getZ()));
            }
        }
        public override void rotateX(float angle) {
            float radians = toRadians(angle);
            foreach (Point3D point in front.points)
            {
                point.setY((float)(Math.Cos(radians) * point.getY() - Math.Sin(radians) * point.getZ()));
                point.setZ((float)(Math.Sin(radians) * point.getY() + Math.Cos(radians) * point.getZ()));
            }
            foreach (Point3D point in back.points)
            {
                point.setY((float)(Math.Cos(radians) * point.getY() - Math.Sin(radians) * point.getZ()));
                point.setZ((float)(Math.Sin(radians) * point.getY() + Math.Cos(radians) * point.getZ()));
            }
        }
        private float toRadians(float degrees)
        {
            return degrees / 57.295f;
        }







    }
}
