using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public abstract class Figure
    {
        protected float rotation = 0;
        protected float scale = 1;
        protected Point3D centroid;

        public abstract void projection();
        public abstract void rotateZ(float angle);
        public abstract void rotateX(float angle);
        public abstract void rotateY(float angle);


    }
    
}
