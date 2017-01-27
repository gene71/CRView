using CR.Core;
using CR.Core.Services;
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
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Creates a new project with the data entered in the form and
        /// exits the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                CRProject crp = new CRProject();
                crp.Name = ProjectNametextBox.Text;
                crp.Description = ProjectDescriptiontextBox.Text;
                newprojectsaveFileDialog.ShowDialog();
                crp.Path = newprojectsaveFileDialog.FileName;
                //write the project
                CRObjSerializer cros = new CRObjSerializer();
                cros.SaveCRObj(crp.Path, crp);
                //set the app var
                AppVar.Project = crp;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }
    }
}
