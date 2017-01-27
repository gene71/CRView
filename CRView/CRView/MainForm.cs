using CRView.AppCache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewProjectForm npf = new NewProjectForm();
            npf.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //update main UI
            updateMainUI();
        }

        private void updateMainUI()
        {
            //Project Panel
            if (AppVar.Project != null)
            {
                projectNamelabel.Text = AppVar.Project.Name;
                projectTemplatelabel.Text = AppVar.Project.Template.TemplateName;
            }
        }

        private void scannerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
