namespace გამოიცანი_გამოსახულება
{
    partial class PictureWithLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.picPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblText.Location = new System.Drawing.Point(0, 102);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 16);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Label";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPicture
            // 
            this.picPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPicture.Location = new System.Drawing.Point(0, 0);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(100, 102);
            this.picPicture.TabIndex = 1;
            this.picPicture.TabStop = false;
            this.picPicture.MouseEnter += new System.EventHandler(this.picPicture_MouseEnter);
            this.picPicture.MouseLeave += new System.EventHandler(this.picPicture_MouseLeave);
            // 
            // PictureWithLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.lblText);
            this.Name = "PictureWithLabel";
            this.Size = new System.Drawing.Size(100, 118);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox picPicture;
    }
}
