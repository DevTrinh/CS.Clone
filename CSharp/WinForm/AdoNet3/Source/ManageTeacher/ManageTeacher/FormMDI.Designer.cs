
namespace ManageTeacher
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sYSTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bASISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEACHERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sYSTEMToolStripMenuItem,
            this.mANAGEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sYSTEMToolStripMenuItem
            // 
            this.sYSTEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.sYSTEMToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sYSTEMToolStripMenuItem.Name = "sYSTEMToolStripMenuItem";
            this.sYSTEMToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.sYSTEMToolStripMenuItem.Text = "SYSTEM";
            // 
            // mANAGEToolStripMenuItem
            // 
            this.mANAGEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bASISToolStripMenuItem});
            this.mANAGEToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANAGEToolStripMenuItem.Name = "mANAGEToolStripMenuItem";
            this.mANAGEToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.mANAGEToolStripMenuItem.Text = "MANAGE";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // bASISToolStripMenuItem
            // 
            this.bASISToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNITToolStripMenuItem});
            this.bASISToolStripMenuItem.Name = "bASISToolStripMenuItem";
            this.bASISToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.bASISToolStripMenuItem.Text = "BASIS";
            this.bASISToolStripMenuItem.Click += new System.EventHandler(this.bASISToolStripMenuItem_Click);
            // 
            // uNITToolStripMenuItem
            // 
            this.uNITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEACHERToolStripMenuItem});
            this.uNITToolStripMenuItem.Name = "uNITToolStripMenuItem";
            this.uNITToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.uNITToolStripMenuItem.Text = "UNIT";
            this.uNITToolStripMenuItem.Click += new System.EventHandler(this.uNITToolStripMenuItem_Click);
            // 
            // tEACHERToolStripMenuItem
            // 
            this.tEACHERToolStripMenuItem.Name = "tEACHERToolStripMenuItem";
            this.tEACHERToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.tEACHERToolStripMenuItem.Text = "TEACHER";
            this.tEACHERToolStripMenuItem.Click += new System.EventHandler(this.tEACHERToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 530);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sYSTEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bASISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEACHERToolStripMenuItem;
    }
}

