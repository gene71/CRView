namespace CRView
{
    partial class NewProjectForm
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
            this.ProjectNamelabel = new System.Windows.Forms.Label();
            this.ProjectNametextBox = new System.Windows.Forms.TextBox();
            this.TemplatecomboBox = new System.Windows.Forms.ComboBox();
            this.ProjectTemplatelabel = new System.Windows.Forms.Label();
            this.NewTemplatebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProjectDescriptionlabel = new System.Windows.Forms.Label();
            this.ProjectDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.newprojectsaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectNamelabel
            // 
            this.ProjectNamelabel.AutoSize = true;
            this.ProjectNamelabel.Location = new System.Drawing.Point(7, 11);
            this.ProjectNamelabel.Name = "ProjectNamelabel";
            this.ProjectNamelabel.Size = new System.Drawing.Size(71, 13);
            this.ProjectNamelabel.TabIndex = 0;
            this.ProjectNamelabel.Text = "Project Name";
            // 
            // ProjectNametextBox
            // 
            this.ProjectNametextBox.Location = new System.Drawing.Point(10, 28);
            this.ProjectNametextBox.Name = "ProjectNametextBox";
            this.ProjectNametextBox.Size = new System.Drawing.Size(434, 20);
            this.ProjectNametextBox.TabIndex = 1;
            // 
            // TemplatecomboBox
            // 
            this.TemplatecomboBox.FormattingEnabled = true;
            this.TemplatecomboBox.Location = new System.Drawing.Point(10, 77);
            this.TemplatecomboBox.Name = "TemplatecomboBox";
            this.TemplatecomboBox.Size = new System.Drawing.Size(434, 21);
            this.TemplatecomboBox.TabIndex = 2;
            // 
            // ProjectTemplatelabel
            // 
            this.ProjectTemplatelabel.AutoSize = true;
            this.ProjectTemplatelabel.Location = new System.Drawing.Point(10, 55);
            this.ProjectTemplatelabel.Name = "ProjectTemplatelabel";
            this.ProjectTemplatelabel.Size = new System.Drawing.Size(87, 13);
            this.ProjectTemplatelabel.TabIndex = 3;
            this.ProjectTemplatelabel.Text = "Project Template";
            // 
            // NewTemplatebutton
            // 
            this.NewTemplatebutton.Location = new System.Drawing.Point(340, 104);
            this.NewTemplatebutton.Name = "NewTemplatebutton";
            this.NewTemplatebutton.Size = new System.Drawing.Size(104, 23);
            this.NewTemplatebutton.TabIndex = 4;
            this.NewTemplatebutton.Text = "New Template";
            this.NewTemplatebutton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectDescriptiontextBox);
            this.panel1.Controls.Add(this.ProjectDescriptionlabel);
            this.panel1.Controls.Add(this.NewTemplatebutton);
            this.panel1.Controls.Add(this.ProjectNamelabel);
            this.panel1.Controls.Add(this.ProjectTemplatelabel);
            this.panel1.Controls.Add(this.ProjectNametextBox);
            this.panel1.Controls.Add(this.TemplatecomboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 275);
            this.panel1.TabIndex = 5;
            // 
            // ProjectDescriptionlabel
            // 
            this.ProjectDescriptionlabel.AutoSize = true;
            this.ProjectDescriptionlabel.Location = new System.Drawing.Point(10, 126);
            this.ProjectDescriptionlabel.Name = "ProjectDescriptionlabel";
            this.ProjectDescriptionlabel.Size = new System.Drawing.Size(96, 13);
            this.ProjectDescriptionlabel.TabIndex = 5;
            this.ProjectDescriptionlabel.Text = "Project Description";
            // 
            // ProjectDescriptiontextBox
            // 
            this.ProjectDescriptiontextBox.Location = new System.Drawing.Point(13, 142);
            this.ProjectDescriptiontextBox.Multiline = true;
            this.ProjectDescriptiontextBox.Name = "ProjectDescriptiontextBox";
            this.ProjectDescriptiontextBox.Size = new System.Drawing.Size(431, 119);
            this.ProjectDescriptiontextBox.TabIndex = 6;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(315, 294);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 6;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(396, 294);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // newprojectsaveFileDialog
            // 
            this.newprojectsaveFileDialog.Filter = "|*.xml";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 348);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewProjectForm";
            this.Text = "New Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProjectNamelabel;
        private System.Windows.Forms.TextBox ProjectNametextBox;
        private System.Windows.Forms.ComboBox TemplatecomboBox;
        private System.Windows.Forms.Label ProjectTemplatelabel;
        private System.Windows.Forms.Button NewTemplatebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProjectDescriptiontextBox;
        private System.Windows.Forms.Label ProjectDescriptionlabel;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.SaveFileDialog newprojectsaveFileDialog;
    }
}