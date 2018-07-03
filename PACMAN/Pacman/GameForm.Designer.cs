namespace Pacman
{
    partial class GameForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.playerImg = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enemyRedImg = new System.Windows.Forms.PictureBox();
            this.enemyPinkImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPinkImg)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImg
            // 
            this.playerImg.Image = ((System.Drawing.Image)(resources.GetObject("playerImg.Image")));
            this.playerImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("playerImg.InitialImage")));
            this.playerImg.Location = new System.Drawing.Point(263, 150);
            this.playerImg.Name = "playerImg";
            this.playerImg.Size = new System.Drawing.Size(62, 63);
            this.playerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImg.TabIndex = 0;
            this.playerImg.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scoreLabel.Location = new System.Drawing.Point(0, 416);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(50, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "SCORE: ";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNameLabel.Location = new System.Drawing.Point(0, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(55, 13);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "PLAYER: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enemyPinkImg);
            this.panel1.Controls.Add(this.enemyRedImg);
            this.panel1.Controls.Add(this.playerImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 403);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // enemyRedImg
            // 
            this.enemyRedImg.Image = ((System.Drawing.Image)(resources.GetObject("enemyRedImg.Image")));
            this.enemyRedImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("enemyRedImg.InitialImage")));
            this.enemyRedImg.Location = new System.Drawing.Point(73, 125);
            this.enemyRedImg.Name = "enemyRedImg";
            this.enemyRedImg.Size = new System.Drawing.Size(62, 63);
            this.enemyRedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyRedImg.TabIndex = 1;
            this.enemyRedImg.TabStop = false;
            // 
            // enemyPinkImg
            // 
            this.enemyPinkImg.Image = ((System.Drawing.Image)(resources.GetObject("enemyPinkImg.Image")));
            this.enemyPinkImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("enemyPinkImg.InitialImage")));
            this.enemyPinkImg.Location = new System.Drawing.Point(73, 233);
            this.enemyPinkImg.Name = "enemyPinkImg";
            this.enemyPinkImg.Size = new System.Drawing.Size(62, 63);
            this.enemyPinkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPinkImg.TabIndex = 2;
            this.enemyPinkImg.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.scoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemyRedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPinkImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerImg;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox enemyPinkImg;
        private System.Windows.Forms.PictureBox enemyRedImg;
    }
}

