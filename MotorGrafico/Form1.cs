using System.Security.Cryptography.X509Certificates;

namespace MotorGrafico
{
    public partial class Form1 : Form
    {
        public static Bitmap bmp;
        public static Graphics graphics;
        public static PointF center;
        private bool rotateX = false;
        private bool rotateY = false;
        private bool rotateZ = false;
        
        private Scene scene;
        public Form1()
        {
            InitializeComponent();
            scene= new Scene();
            PICTURE_BOX.Size= new Size(this.Size.Width-200 , this.Size.Height-200);
            PICTURE_BOX.Location = new Point(100,100);
            center=new Point(PICTURE_BOX.Width/2,PICTURE_BOX.Height/2);
            bmp = new Bitmap(PICTURE_BOX.Width, PICTURE_BOX.Height);
            graphics = Graphics.FromImage(bmp);
            PICTURE_BOX.Image = bmp;
            PICTURE_BOX.Invalidate();
            
           
            Cube cube1 = new Cube( new Point3D(0,0,0), 0.75f) ;
            Cube cube2 = new Cube(new Point3D(0, 0, 0), 0.25f);
            scene.getFigures().Add(cube1);
            scene.getFigures().Add(cube2);



        }

        private void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);
            //graphics.DrawLine(Pens.Yellow, new PointF(0f,center.Y),new PointF(PICTURE_BOX.Width,center.Y));
            //graphics.DrawLine(Pens.Yellow, new PointF(center.X, 0), new PointF(center.X, PICTURE_BOX.Width));
            foreach(Figure fig in scene.getFigures())
            {
                fig.projection();
                if (rotateX)
                    fig.rotateX(1f);
                if (rotateY)
                    fig.rotateY(1f);
                if (rotateZ)
                    fig.rotateZ(1f);

            }
            
            
            PICTURE_BOX.Invalidate();
            

        }

        

        private void ROTATE_X_Click(object sender, EventArgs e) {
            rotateX = !rotateX;
        }

        private void ROTATE_Y_Click(object sender, EventArgs e)
        {
            rotateY= !rotateY;
        }

        private void ROTATE_Z_Click(object sender, EventArgs e)
        {
          rotateZ = !rotateZ;
        }
    }
}