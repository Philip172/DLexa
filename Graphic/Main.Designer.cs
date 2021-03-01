
namespace Graphic
{
    partial class Main
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPointCount = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pnlGraphic = new System.Windows.Forms.Panel();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.tbPointCount);
            this.pnlControl.Controls.Add(this.tbX2);
            this.pnlControl.Controls.Add(this.tbX1);
            this.pnlControl.Controls.Add(this.btnDraw);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Location = new System.Drawing.Point(654, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(235, 491);
            this.pnlControl.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во точек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "X2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "X1";
            // 
            // tbPointCount
            // 
            this.tbPointCount.Location = new System.Drawing.Point(110, 70);
            this.tbPointCount.Name = "tbPointCount";
            this.tbPointCount.Size = new System.Drawing.Size(100, 23);
            this.tbPointCount.TabIndex = 2;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(110, 41);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 23);
            this.tbX2.TabIndex = 2;
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(110, 12);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 23);
            this.tbX1.TabIndex = 2;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(29, 113);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(181, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Построить";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pnlGraphic
            // 
            this.pnlGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraphic.Location = new System.Drawing.Point(0, 0);
            this.pnlGraphic.Name = "pnlGraphic";
            this.pnlGraphic.Size = new System.Drawing.Size(654, 491);
            this.pnlGraphic.TabIndex = 1;
            this.pnlGraphic.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGraphic_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 491);
            this.Controls.Add(this.pnlGraphic);
            this.Controls.Add(this.pnlControl);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Main";
            this.Text = "График";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPointCount;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.Panel pnlGraphic;
    }
}

