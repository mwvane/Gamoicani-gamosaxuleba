namespace გამოიცანი_გამოსახულება
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlResult = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tmrSlider = new System.Windows.Forms.Timer(this.components);
            this.imageButton1 = new Mwvane_UI.ImageButton();
            this.elipse1 = new Mwvane_UI.Elipse(this.components);
            this.dragControler1 = new Mwvane_UI.DragControler(this.components);
            this.btnRefresh = new Mwvane_UI.ImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlResult
            // 
            this.pnlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResult.AutoScroll = true;
            this.pnlResult.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.pnlResult.BackColor = System.Drawing.Color.Transparent;
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.ForeColor = System.Drawing.Color.White;
            this.pnlResult.Location = new System.Drawing.Point(0, 80);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(473, 0);
            this.pnlResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(206, 35);
            this.txtLength.MaxLength = 2;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(24, 20);
            this.txtLength.TabIndex = 0;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contains:";
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(291, 35);
            this.txtContains.MaxLength = 14;
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(111, 20);
            this.txtContains.TabIndex = 1;
            this.txtContains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContains_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Animals",
            "Sports",
            "Retro",
            "Professions",
            "NoCategory",
            "Flags"});
            this.comboBox1.Location = new System.Drawing.Point(53, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "NoCategory";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(408, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tmrSlider
            // 
            this.tmrSlider.Interval = 1;
            this.tmrSlider.Tick += new System.EventHandler(this.tmrSlider_Tick);
            // 
            // imageButton1
            // 
            this.imageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButton1.Image = ((System.Drawing.Image)(resources.GetObject("imageButton1.Image")));
            this.imageButton1.Location = new System.Drawing.Point(450, 3);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(15, 15);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButton1.TabIndex = 4;
            this.imageButton1.TabStop = false;
            this.imageButton1.ZoomSize = ((byte)(2));
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // elipse1
            // 
            this.elipse1.ContainerControl = this;
            this.elipse1.ElipseSize = 11;
            // 
            // dragControler1
            // 
            this.dragControler1.Components = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(432, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(15, 15);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.ZoomSize = ((byte)(2));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(471, 80);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtContains);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Timer tmrSlider;
        private Mwvane_UI.Elipse elipse1;
        private Mwvane_UI.ImageButton imageButton1;
        private Mwvane_UI.DragControler dragControler1;
        private Mwvane_UI.ImageButton btnRefresh;
        private System.Windows.Forms.Timer timer1;
    }
}

