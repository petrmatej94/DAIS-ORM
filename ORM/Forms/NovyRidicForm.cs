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
    public partial class NovyRidicForm : Form
    {
        private Ridic ridic = new Ridic();
        ErrorProvider errorProvider = new ErrorProvider();
        private bool newRecord = true;
        string skupina;

        FormRidicGrid parent;



        public NovyRidicForm()
        {
            InitializeComponent();

            Collection<Skupina> skupiny = SkupinaTable.Select();
            comboBoxSkupina.DisplayMember = "Skupina";
            comboBoxSkupina.ValueMember = "Skupina";
            comboBoxSkupina.DataSource = skupiny;
        }

        public void GetParentForm(FormRidicGrid p)
        {
            parent = p;
        }

        private bool GetData()
        {
            bool ret = true;
            DateTime dateTime;

            errorProvider.Clear();
            
            ridic.Jmeno = BoxJmeno.Text;
            ridic.Ulice = BoxUlice.Text;
            ridic.Mesto = BoxMesto.Text;
            ridic.Stat = BoxStat.Text;
            ridic.Obcanstvi = BoxObcanstvi.Text;
            
            if (DateTime.TryParse(BoxDatum.Text, out dateTime))
            {
                ridic.Datum_narozeni = dateTime;
            }
            else
            {
                errorProvider.SetError(BoxDatum, "Špatný format datumu narození");
                ret = false;
            }

            skupina = (string)comboBoxSkupina.SelectedValue;

            return ret;
        }


        protected bool PridatRidice()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    RidicTable.NovyRidic(ridic, skupina);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(PridatRidice())
            {
                parent.RefreshData();
                Close();
            }
        }

        private void comboBoxSkupina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NovyRidic_Load(object sender, EventArgs e)
        {

        }
    }
}
