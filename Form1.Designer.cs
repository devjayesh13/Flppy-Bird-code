
namespace plappy_bird
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            this.SuspendLayout();
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(3, 9);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(164, 52);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // ground
            // 
            this.ground.Image = global::plappy_bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-11, 616);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(853, 99);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::plappy_bird.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(283, -72);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 241);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 2;
            this.pipetop.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::plappy_bird.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(249, 412);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(100, 212);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.Image = global::plappy_bird.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(12, 240);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(83, 73);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(474, 699);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.flappybird);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flappy bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
    }
}

