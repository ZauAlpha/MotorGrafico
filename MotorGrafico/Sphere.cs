using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    
    
        public class Sphere : Figure
        {
            private int numSegments;
            private float radius;
            private List<Triangle> triangles;

            public Sphere(float radius, int numSegments)
            {
                this.radius = radius;
                this.numSegments = numSegments;
                triangles = new List<Triangle>();
                float angle = 360 / numSegments;
                float deltaRadius = radius/numSegments;
                float x = (float)Math.Cos(toRadians(angle / 2)) * radius;
                float y = (float)Math.Sin(toRadians(angle / 2)) * radius;
                

            // Create the triangles that form the surface of the sphere
            for (int i = 0; i < numSegments+1; i++)
                    {
                
                    float lat0 = (float)Math.PI * (-0.5f + (float)(i-1) / numSegments);
                    float z0 = (float)Math.Sin(lat0) * radius;
                    float zr0 = (float)Math.Cos(lat0) * radius;

                    float lat1 = (float)Math.PI * (-0.5f + (float)i / numSegments);
                    float z1 = (float)Math.Sin(lat1) * radius;
                    float zr1 = (float)Math.Cos(lat1) * radius;

                    for (int j = 0; j < numSegments; j++)
                    {
                        float lng0 = (float)(2 * Math.PI * (float)(j-1) / numSegments);
                        float x0 = (float)Math.Cos(lng0) * zr0;
                        float y0 = (float)Math.Sin(lng0) * zr0;

                        float lng1 = (float)(2 * Math.PI * (float)j / numSegments);
                        float x1 = (float)Math.Cos(lng1) * zr0;
                        float y1 = (float)Math.Sin(lng1) * zr0;

                        float x2 = (float)Math.Cos(lng0) * zr1;
                        float y2 = (float)Math.Sin(lng0) * zr1;

                        float x3 = (float)Math.Cos(lng1) * zr1;
                        float y3 = (float)Math.Sin(lng1) * zr1;

                        Point3D p0 = new Point3D(x0, y0, z0);
                        Point3D p1 = new Point3D(x1, y1, z0);
                        Point3D p2 = new Point3D(x2, y2, z1);
                        Point3D p3 = new Point3D(x3, y3, z1);
                    if (i == 0){}
                    else if (i == 1) 
                        triangles.Add(new Triangle(p3, p2, p1, Color.DarkBlue));
                    
                    else 
                        triangles.Add(new Triangle(p0, p1, p2, Color.DarkBlue));
                    
                }
                }

            // Calculate the centroid of the sphere
           

        }

            public override void projection()
            {
                foreach (Triangle t in triangles)
                {
                    t.projection();
                }
            }

            public override void rotateX(float angle)
            {
                foreach (Triangle t in triangles)
                {
                    t.rotateX(angle);
                }
            }

            public override void rotateY(float angle)
            {
                foreach (Triangle t in triangles)
                {
                    t.rotateY(angle);
                }
            }

            public override void rotateZ(float angle)
            {
                foreach (Triangle t in triangles)
                {
                    t.rotateZ(angle);
                }
            }
        }
    }

