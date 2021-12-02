namespace PictureShapes
{
    partial class PictureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.canvas = new PictureShapes.Canvas();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(506, 772);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(168, 57);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Roll";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(4, 5);
            this.canvas.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1196, 758);
            this.canvas.TabIndex = 1;
            this.canvas.Load += new System.EventHandler(this.canvas_Load);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 829);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.btnDraw);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PictureForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private Canvas canvas;
    }
}

