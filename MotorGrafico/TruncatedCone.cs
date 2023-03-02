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
            int number = 15;
            float noSeComoLlamarEstaVariable = 360 / number;
            this.height = height;
            this.minRadius = minRadius;
            this.majRadius = majRadius;
            float z1 = -height / 2;
            float z2 = height / 2;
            float a1 = majRadius / 5;
            float a2 = minRadius / 5;
            for (int i = 0; i <= number; i++)
            {

                // Draw triangles Circle 1
                Triangle triangle1 = new Triangle(new Point3D(0, 0, z1), new Point3D(majRadius, -a1, z1), new Point3D(majRadius, a1, z1), Color.Green);
                // Draw triangles Circle 2
                Triangle triangle2 = new Triangle(new Point3D(radius, 0, z2), new Point3D(majRadius, -a1, z1), new Point3D(majRadius, a1, z1), Color.Green);
                // Draw triangles for the circle1
                Triangle triangle3 = new Triangle(new Point3D(0, 0, z2), new Point3D(radius, a, z2), new Point3D(radius, -a, z2), Color.Green);
                // Draw triangles for the circle2
                Triangle triangle4 = new Triangle(new Point3D(radius, 0, z1), new Point3D(radius, a, z2), new Point3D(radius, -a, z2), Color.Green);
                // rotate the triangles for the first cirlce
                triangle1.rotateZ(noSeComoLlamarEstaVariable * i);
                triangle2.rotateZ(noSeComoLlamarEstaVariable * i);
                // rotate the triangles for the other cirlce 
                triangle3.rotateZ((noSeComoLlamarEstaVariable * i) + (noSeComoLlamarEstaVariable / 2));
                triangle4.rotateZ((noSeComoLlamarEstaVariable * i) + (noSeComoLlamarEstaVariable / 2));
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
