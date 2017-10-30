﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }
        



        private void FormHelp_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(ManagerThema.Themaprefix + "HelpAchtergrond");

            if (ManagerThema.Themaprefix == "Thema0")
            {
                label3.ForeColor = System.Drawing.Color.DarkRed;
                label4.ForeColor = System.Drawing.Color.DarkRed;
                label9.ForeColor = System.Drawing.Color.DarkRed;
                label6.ForeColor = System.Drawing.Color.DarkRed;
                label7.ForeColor = System.Drawing.Color.DarkRed;
                label8.ForeColor = System.Drawing.Color.DarkRed;
            }
            else if (ManagerThema.Themaprefix == "Thema1")
            {
                label3.ForeColor = System.Drawing.Color.Blue;
                label4.ForeColor = System.Drawing.Color.Blue;
                label9.ForeColor = System.Drawing.Color.Blue;
                label6.ForeColor = System.Drawing.Color.Blue;
                label7.ForeColor = System.Drawing.Color.Blue;
                label8.ForeColor = System.Drawing.Color.Blue;
            }
            else if (ManagerThema.Themaprefix == "Thema2")
            {
                label3.ForeColor = System.Drawing.Color.Black;
                label4.ForeColor = System.Drawing.Color.Black;
                label9.ForeColor = System.Drawing.Color.Black;
                label6.ForeColor = System.Drawing.Color.Black;
                label7.ForeColor = System.Drawing.Color.Black;
                label8.ForeColor = System.Drawing.Color.Black;
            }




        }



        
        private void FormHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
