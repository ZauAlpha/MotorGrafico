using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class Cilinder : Figure
    {
        private List<Triangle> triangles;
        private float height, radius;
        public Cilinder(float height, float radius)
        {
            triangles = new List<Triangle>();
            int number =90;
            float angle = 360 / number;
            
            this.height = height;
            this.radius = radius;
            float z1 = -height / 2;
            float z2 = height / 2;
            float x = (float)Math.Cos(toRadians(angle / 2)) * radius;
            float y = (float)Math.Sin(toRadians(angle / 2)) * radius;
            
            for (int i = 0; i <= number; i++)
            {
                //Draw circle 1
                Triangle triangle1 = new Triangle(new Point3D(x, y, z1), new Point3D(x,-y, z1), new Point3D(0, 0 , z1), Color.Yellow);
                // Draw triangles for the circle1
                Triangle triangle2 = new Triangle(new Point3D(x, 0, z2), new Point3D(x, -y, z1), new Point3D(x, y, z1), Color.Yellow);
                // Draw Circle 2
                Triangle triangle3 = new Triangle(new Point3D(0, 0, z2), new Point3D(x, -y, z2), new Point3D(x,y, z2), Color.Yellow);
                // Draw triangles for the circle2
                Triangle triangle4 = new Triangle(new Point3D(x, y, z2), new Point3D(x, -y, z2) , new Point3D(x, 0, z1), Color.Yellow);
                // rotate the triangles for the first cirlce
                triangle1.rotateZ(angle * i);
                triangle2.rotateZ(angle * i);
                // rotate the triangles for the other cirlce 
                triangle3.rotateZ((angle * (i+.5f)) );
                triangle4.rotateZ((angle * (i+.5f)) );
                //add it to the scene
                triangles.Add(triangle1);
                //triangles.Add(triangle2);
                triangles.Add(triangle3);
                triangles.Add(triangle4);
            }

        }
        public override void projection()
        {
            for (int i = 0; i < triangles.Count(); i++)
                triangles[i].projection();
            
        }
        public override void rotateX(float angle)
        {
            for (int i = 0; i < triangles.Count(); i++)
                triangles[i].rotateX(angle);
            
        }
        public override void rotateY(float angle)
        {
            for (int i = 0; i < triangles.Count(); i++)
                triangles[i].rotateY(angle);
        }
        public override void rotateZ(float angle)
        {
            for (int i = 0; i < triangles.Count(); i++)
                triangles[i].rotateZ(angle);
        }
    }
}
