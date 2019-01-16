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
    public partial class ZaznamGridForm : Form
    {

        public ZaznamGridForm()
        {
            InitializeComponent();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int id = (int)primaryKey;
                Collection<Zaznam> zaznamy = ZaznamTable.SelectRidic(id);

                BindingList<Zaznam> bindingList = new BindingList<Zaznam>(zaznamy);
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = bindingList;
            }
            return true;
        }
    }
}
