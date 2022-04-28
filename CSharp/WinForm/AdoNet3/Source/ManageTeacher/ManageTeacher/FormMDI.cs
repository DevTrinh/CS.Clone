using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTeacher
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want Exit ? ", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bASISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBasis fBasis = new FormBasis();
            fBasis.MdiParent = this;
            fBasis.Show();
        }

        private void uNITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnit fUnit = new FormUnit();
            fUnit.MdiParent = this;
            fUnit.Show();
        }

        private void tEACHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher fTeacher = new FormTeacher();
            fTeacher.MdiParent = this;
            fTeacher.Show();
        }
    }
}
