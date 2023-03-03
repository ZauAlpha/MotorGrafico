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


            //scene.getFigures().Add(new Cilinder(1f,.5f));
            float radius = 0.5f;
            int number = 30;
            float angle = (360/number) / 57.295f; ;
            float x = (float)(Math.Cos(angle/2) * radius);
            float y = (float)(Math.Sin(angle/2) * radius);
            for (int i = 0; i < number; i++)
            {
                //scene.getFigures().Add(new Triangle( new Point3D(x, y, 0), new Point3D(x, -y, 0), new Point3D(0, 0, 0)));
            }
            //scene.getFigures().Add(new Cone(1f, 0.25f));
            //scene.getFigures().Add(new Cilinder(1f, 0.5f));
            //scene.getFigures().Add(new TruncatedCone(1f, 0.25f, 0.5f));
            scene.getFigures().Add(new Sphere(0.45f, 35));





        }

        private void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.DarkGray);
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

        private void ROTATE_ALL_Click(object sender, EventArgs e)
        {
            
            if(rotateX || rotateY || rotateZ)
            {
                rotateX = false;
                rotateY = false;
                rotateZ = false;
                return;
            }
            rotateX = true;
            rotateY = true;
            rotateZ = true;
        }
    }
}