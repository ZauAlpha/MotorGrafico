using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class Cone : Figure
    {
        private List<Triangle> triangles;
        private float height, raidus;
        public Cone(float height, float radius)
        {
            triangles = new List<Triangle>();
            int number = 15;
            float noSeComoLlamarEstaVariable = 360 / number;
            this.height = height;
            this.raidus = raidus;
            float z1 = -height / 2;
            float z2 = height / 2;
            float a = radius / 5;
            for (int i = 0; i <= number; i++)
            {

                // Draw triangles Circle 1
                Triangle triangle1 = new Triangle(new Point3D(0, 0, z1), new Point3D(radius, -a, z1), new Point3D(radius, a, z1), Color.Green);
                // Draw triangles Circle 2
                Triangle triangle2 = new Triangle(new Point3D(0, 0, z2), new Point3D(radius, -a, z1), new Point3D(radius, a, z1), Color.Green);
                // Draw triangles for the circle1
                
                // rotate the triangles for the first cirlce
                triangle1.rotateZ(noSeComoLlamarEstaVariable * i);
                triangle2.rotateZ(noSeComoLlamarEstaVariable * i);
                // rotate the triangles for the other cirlce 
                triangles.Add(triangle1);
                triangles.Add(triangle2);
                
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
