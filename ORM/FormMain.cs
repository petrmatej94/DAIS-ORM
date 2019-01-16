using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM.Database
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void novýŘidičToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.NovyRidicForm form = new Forms.NovyRidicForm();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AktualizaceRidiceForm form = new Forms.AktualizaceRidiceForm();
            form.MdiParent = this;
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.MdiParent = this;
            form.Show();
        }

        private void výpisŘidičůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FormRidicGrid form = new Forms.FormRidicGrid();
            form.MdiParent = this;
            form.Show();
        }
    }
}
