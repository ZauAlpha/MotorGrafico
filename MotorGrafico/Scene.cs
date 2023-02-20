using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorGrafico
{
    public class Scene
    {
        private List<Figure> figures;
        
            public Scene()
        {
            figures = new List<Figure>();  
        }
        public List<Figure> getFigures() {
            return figures;
        }
       
    }
}
