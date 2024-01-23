using Mater_Audio_Terminal.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mater_Audio_Terminal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sideBarExpand = true;
        private void sideBarTransistion_Tick(object sender, EventArgs e)
        {
            if(sideBarExpand)
            {
                sideBar.Width -= 5;
                if(sideBar.Width <= 50)
                {
                    sideBarExpand = false;
                    sideBarTransistion.Stop();
                    sidebarPanel.Width = sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 237)
                {
                    sideBarExpand = true;
                    sideBarTransistion.Stop();
                    sidebarPanel.Width = sideBar.Width;
                }
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sideBarTransistion.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("dashboard clicked");
            UC_Dashboard ucd = new UC_Dashboard();
            addUserControl(ucd);
        }
    }
}
