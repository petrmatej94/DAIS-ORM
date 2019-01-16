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
    public partial class VozidlaRidiceGridForm : Form
    {
        public VozidlaRidiceGridForm()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int id = (int)primaryKey;
                Collection<Vozidlo> vozidla = VozidloTable.VypisVozidelRidice(id);

                BindingList<Vozidlo> bindingList = new BindingList<Vozidlo>(vozidla);
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = bindingList;
            }
            return true;
        }




    }
}
