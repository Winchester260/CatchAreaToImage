namespace CatchAreaToImage
{
    partial class Form1
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
            this.pBArea = new System.Windows.Forms.PictureBox();
            this.btnSelectArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pBArea
            // 
            this.pBArea.Location = new System.Drawing.Point(12, 70);
            this.pBArea.Name = "pBArea";
            this.pBArea.Size = new System.Drawing.Size(139, 51);
            this.pBArea.TabIndex = 1;
            this.pBArea.TabStop = false;
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Location = new System.Drawing.Point(35, 22);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(94, 29);
            this.btnSelectArea.TabIndex = 2;
            this.btnSelectArea.Text = "Select Area";
            this.btnSelectArea.UseVisualStyleBackColor = true;
            this.btnSelectArea.Click += new System.EventHandler(this.BtnSelectArea_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 133);
            this.Controls.Add(this.btnSelectArea);
            this.Controls.Add(this.pBArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CatchArea";
            ((System.ComponentModel.ISupportInitialize)(this.pBArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBArea;
        private System.Windows.Forms.Button btnSelectArea;
    }
}

