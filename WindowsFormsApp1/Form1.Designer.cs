namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myButton4 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton3 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton2 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton1 = new WindowsFormsControlLibrary1.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1036, 188);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(27, 319);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(297, 291);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(689, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 292);
            this.dataGridView1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(30, 617);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1029, 203);
            this.flowLayoutPanel3.TabIndex = 5;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(331, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // myButton4
            // 
            this.myButton4.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.myButton4.FillColor2 = System.Drawing.Color.Empty;
            this.myButton4.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton4.Location = new System.Drawing.Point(521, 22);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(162, 72);
            this.myButton4.TabIndex = 7;
            this.myButton4.Text = "favor";
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton3
            // 
            this.myButton3.FillColor1 = System.Drawing.Color.White;
            this.myButton3.FillColor2 = System.Drawing.Color.Yellow;
            this.myButton3.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton3.Location = new System.Drawing.Point(354, 21);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(128, 73);
            this.myButton3.TabIndex = 6;
            this.myButton3.Text = "flickr";
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton2
            // 
            this.myButton2.FillColor1 = System.Drawing.Color.Green;
            this.myButton2.FillColor2 = System.Drawing.Color.Empty;
            this.myButton2.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton2.Location = new System.Drawing.Point(194, 34);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(102, 59);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "myButton2";
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myButton1.FillColor2 = System.Drawing.Color.Empty;
            this.myButton1.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton1.Location = new System.Drawing.Point(30, 34);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(119, 60);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "GetProducts";
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 823);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.MyButton myButton1;
        private WindowsFormsControlLibrary1.MyButton myButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Timer timer1;
        private WindowsFormsControlLibrary1.MyButton myButton3;
        private WindowsFormsControlLibrary1.MyButton myButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

