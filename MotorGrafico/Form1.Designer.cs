namespace MotorGrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PICTURE_BOX = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ROTATE_X = new System.Windows.Forms.Button();
            this.ROTATE_Y = new System.Windows.Forms.Button();
            this.ROTATE_Z = new System.Windows.Forms.Button();
            this.ROTATE_ALL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // PICTURE_BOX
            // 
            this.PICTURE_BOX.BackColor = System.Drawing.Color.Black;
            this.PICTURE_BOX.Location = new System.Drawing.Point(100, 100);
            this.PICTURE_BOX.Name = "PICTURE_BOX";
            this.PICTURE_BOX.Size = new System.Drawing.Size(100, 50);
            this.PICTURE_BOX.TabIndex = 0;
            this.PICTURE_BOX.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ROTATE_X
            // 
            this.ROTATE_X.Location = new System.Drawing.Point(45, 23);
            this.ROTATE_X.Name = "ROTATE_X";
            this.ROTATE_X.Size = new System.Drawing.Size(75, 23);
            this.ROTATE_X.TabIndex = 2;
            this.ROTATE_X.Text = "rotateX";
            this.ROTATE_X.UseVisualStyleBackColor = true;
            this.ROTATE_X.Click += new System.EventHandler(this.ROTATE_X_Click);
            // 
            // ROTATE_Y
            // 
            this.ROTATE_Y.Location = new System.Drawing.Point(126, 23);
            this.ROTATE_Y.Name = "ROTATE_Y";
            this.ROTATE_Y.Size = new System.Drawing.Size(75, 23);
            this.ROTATE_Y.TabIndex = 3;
            this.ROTATE_Y.Text = "rotateY";
            this.ROTATE_Y.UseVisualStyleBackColor = true;
            this.ROTATE_Y.Click += new System.EventHandler(this.ROTATE_Y_Click);
            // 
            // ROTATE_Z
            // 
            this.ROTATE_Z.Location = new System.Drawing.Point(207, 23);
            this.ROTATE_Z.Name = "ROTATE_Z";
            this.ROTATE_Z.Size = new System.Drawing.Size(75, 23);
            this.ROTATE_Z.TabIndex = 4;
            this.ROTATE_Z.Text = "rotateZ";
            this.ROTATE_Z.UseVisualStyleBackColor = true;
            this.ROTATE_Z.Click += new System.EventHandler(this.ROTATE_Z_Click);
            // 
            // ROTATE_ALL
            // 
            this.ROTATE_ALL.Location = new System.Drawing.Point(356, 23);
            this.ROTATE_ALL.Name = "ROTATE_ALL";
            this.ROTATE_ALL.Size = new System.Drawing.Size(75, 23);
            this.ROTATE_ALL.TabIndex = 5;
            this.ROTATE_ALL.Text = "rotate all";
            this.ROTATE_ALL.UseVisualStyleBackColor = true;
            this.ROTATE_ALL.Click += new System.EventHandler(this.ROTATE_ALL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.ROTATE_ALL);
            this.Controls.Add(this.ROTATE_Z);
            this.Controls.Add(this.ROTATE_Y);
            this.Controls.Add(this.ROTATE_X);
            this.Controls.Add(this.PICTURE_BOX);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PICTURE_BOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PICTURE_BOX;
        private System.Windows.Forms.Timer timer;
        private Button ROTATE_X;
        private Button ROTATE_Y;
        private Button ROTATE_Z;
        private Button ROTATE_ALL;
    }
}