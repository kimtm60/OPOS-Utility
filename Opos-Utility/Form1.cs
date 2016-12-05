using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Opos_Utility
{
    public partial class Form1 : Form
    {
        PTR child1 = new PTR();
        CDP child2 = new CDP();
        MSR child3 = new MSR();
        SCN child4 = new SCN();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {



            child1.TopLevel = false;

            child2.TopLevel = false;

            child3.TopLevel = false;

            child4.TopLevel = false;

            this.Controls.Add(child1);

            this.Controls.Add(child2);

            this.Controls.Add(child3);

            this.Controls.Add(child4);



            child1.Parent = this.panel1;
            child1.Dock = DockStyle.Fill;
            child2.Parent = this.panel1;
            child2.Dock = DockStyle.Fill;

            child3.Parent = this.panel1;
            child3.Dock = DockStyle.Fill;
            child4.Parent = this.panel1;
            child4.Dock = DockStyle.Fill;


            // 자식 폼의 타이틀을 없앤다 

            child1.Text = child2.Text = child3.Text = child4.Text = "";

            child1.ControlBox = child2.ControlBox = child3.ControlBox =child4.ControlBox =  false;

            child1.Show();

        }



       



        private void ptr_init_Click(object sender, EventArgs e)
        {
            child2.Hide();

            child3.Hide();

            child4.Hide();

            child1.Show();
        }

        private void cdp_init_Click(object sender, EventArgs e)
        {
            child1.Hide();

            child3.Hide();

            child4.Hide();

            child2.Show();
        }

        private void msr_init_Click(object sender, EventArgs e)
        {
            child1.Hide();

            child2.Hide();

            child4.Hide();

            child3.Show();
        }

        private void scn_init_Click(object sender, EventArgs e)
        {
            child1.Hide();

            child2.Hide();

            child3.Hide();

            child4.Show();
        }
    }
}