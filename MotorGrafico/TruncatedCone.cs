using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class TruncatedCone : Figure
    {
        private List<Triangle> triangles;
        private float height, minRadius,majRadius;
        public TruncatedCone(float height, float minRadius, float majRadius)
        {
            triangles = new List<Triangle>();
            int number = 90;
            float angle = 360 / number;
            this.height = height;
            this.minRadius = minRadius;
            this.majRadius = majRadius;
            float z1 = -height / 2;
            float z2 = height / 2;
            float x1 = (float)Math.Cos(toRadians(angle / 2)) * minRadius ;
            float x2 = (float)Math.Cos(toRadians(angle / 2)) * majRadius ;
            float y1 = (float)Math.Sin(toRadians(angle / 2)) * minRadius ;
            float y2 = (float)Math.Sin(toRadians(angle / 2)) * majRadius ;
            
            for (int i = 0; i <= number; i++)
            {
                // Draw minor circle
                Triangle triangle1 = new Triangle(new Point3D(0, 0, z1), new Point3D(x1, y1, z1), new Point3D(x1, -y1, z1), Color.Pink);
                // Draw triangles for the circle1
                Triangle triangle2 = new Triangle(new Point3D(x2, 0, z2), new Point3D(x1, y1, z1), new Point3D(x1, -y1, z1), Color.Pink);
                // Draw greater Circle 2
                Triangle triangle3 = new Triangle(new Point3D(0, 0, z2), new Point3D(x2, -y2, z2), new Point3D(x2, y2, z2), Color.Pink);
                // Draw triangles for the circle2
                Triangle triangle4 = new Triangle(new Point3D(x1, 0, z1), new Point3D(x2, y2, z2), new Point3D(x2, -y2, z2), Color.Pink);
                // rotate the triangles for the first cirlce
                triangle1.rotateZ(angle * i);
                triangle2.rotateZ(angle * i);
                // rotate the triangles for the other cirlce 
                triangle3.rotateZ((angle * (i + .5f)));
                triangle4.rotateZ((angle * (i + .5f)));
                //add it to the scene
                triangles.Add(triangle1);
                triangles.Add(triangle2);
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
