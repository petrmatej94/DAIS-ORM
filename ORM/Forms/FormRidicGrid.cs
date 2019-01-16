using ORM.Database;
using ORM.Database.dao_sqls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM.Forms
{
    public partial class FormRidicGrid : Templates.FormGrid
    {
        public FormRidicGrid()
        {
            InitializeComponent();
            RefreshData();
        }


        private Ridic GetSelectedRidic()
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                Ridic ridic = dataGrid.SelectedRows[0].DataBoundItem as Ridic;
                return ridic;
            }
            else
            {
                return null;
            }
        }

        protected override void upravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ridic selectedRidic = GetSelectedRidic();
            if(selectedRidic != null)
            {
                Forms.AktualizaceRidiceForm form = new Forms.AktualizaceRidiceForm();
                form.GetParentForm(this);
                if (form.OpenRecord(selectedRidic.Uid))
                {
                    form.MdiParent = this.ParentForm;
                    form.Show();
                }
            }
        }


        public void RefreshData()
        {
            Collection<Ridic> ridici = RidicTable.Select();
            BindingList<Ridic> bindingList = new BindingList<Ridic>(ridici);
            dataGrid.AutoGenerateColumns = false;
            dataGrid.DataSource = bindingList;
        }

        protected override void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        protected override void novýŘidičToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.NovyRidicForm form = new Forms.NovyRidicForm();
            form.GetParentForm(this);
            form.MdiParent = this.ParentForm;
            form.Show();
        }

        protected override void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ridic selectedRidic = GetSelectedRidic();

            if (selectedRidic != null)
            {
                Forms.DetailRidiceForm form = new Forms.DetailRidiceForm();
                form.GetParentForm(this);

                if (form.OpenRecord(selectedRidic.Uid))
                {
                    form.MdiParent = this.ParentForm;
                    form.Show();
                }
            }
        }

        protected override void smazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ridic selectedRidic = GetSelectedRidic();

            if (selectedRidic != null)
            {
                RidicTable.Delete(selectedRidic.Uid);
                RefreshData();
            }
        }

        private void FormRidicGrid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
