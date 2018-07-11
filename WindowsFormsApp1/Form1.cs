using MyAWEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;
using PhotoDataModel_V2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel2.AutoScroll = true;


        }

        


        private void myButton1_Click(object sender, EventArgs e)
        {
            AdventureWorksEntities dbContext = new AdventureWorksEntities();
            var q = from p in dbContext.ProductPhotoes
                    select p;

            List<ProductPhoto> productList = q.ToList();
            this.dataGridView1.DataSource = productList;
            for (int i = 0; i <= productList.Count - 1; i++)
            {
                MyItemTemplate x = new MyItemTemplate();
                x.Desc = productList[i].ModifiedDate.ToString();
                x.ImageBytes = productList[i].LargePhoto;

                this.flowLayoutPanel2.Controls.Add(x);
                Application.DoEvents();
            }

            for (int i = 0; i <= productList.Count - 1; i++)
            {
                MyItemTemplate x = new MyItemTemplate();
                x.Desc = productList[i].ModifiedDate.Value.ToShortDateString();
                x.ImageBytes = productList[i].LargePhoto;

                this.flowLayoutPanel1.Controls.Add(x);
                Application.DoEvents();
            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            List<PhotoDataItem> photoList = PhotoDataSource.Search(SearchTerm: "Microsoft", results: 200);
            this.dataGridView1.DataSource = photoList;

            for (int i = 0; i <= photoList.Count - 1; i++)
            {
                MyItemTemplate x = new MyItemTemplate();
                x.Desc = photoList[i].Title;
                x.ImageURL = photoList[i].ImagePath;

                this.flowLayoutPanel2.Controls.Add(x);
                Application.DoEvents();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();

        }

        async private void myButton3_Click(object sender, EventArgs e)
        {
            List<PhotoDataItem> photoList = await PhotoDataSource.SearchAsync(SearchTerm: "WorldCup", results:10);
            this.dataGridView1.DataSource = photoList;

            for (int i = 0; i <= photoList.Count - 1; i++)
            {
                MyItemTemplate x = new MyItemTemplate();
                x.Desc = photoList[i].Title;
                x.ImageURL = photoList[i].ImagePath;
                
                

                this.flowLayoutPanel1.Controls.Add(x);
                Application.DoEvents();

                x.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
                x.pictureBox1.Click += PictureBox1_Click;

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p1 = (PictureBox)sender;
            this.pictureBox1.Image = p1.Image;

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanel3.Controls.Clear();
            foreach (MyItemTemplate x in flowLayoutPanel1.Controls)
            {
                if(x.checkBox1.Checked)
                {
                MyItemTemplate y = new MyItemTemplate();
                y.Desc = x.Desc;
                y.ImageURL = x.ImageURL;
                this.flowLayoutPanel3.Controls.Add(y);
                Application.DoEvents();
                }
                

            }
        }

        private void myButton4_Click(object sender, EventArgs e)
        {


        }
    }
}
