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
    public partial class AktualizaceRidiceForm : Form
    {
        Ridic ridic = new Ridic();
        Zaznam zaznam = new Zaznam();
        int expirace;
        ErrorProvider errorProvider = new ErrorProvider();

        FormRidicGrid parent;
        DetailRidiceForm detailForm;


        public AktualizaceRidiceForm()
        {
            InitializeComponent();
            
        }

        public bool OpenRecord(object primaryKey)
        {
            if(primaryKey != null)
            {
                int id = (int)primaryKey;
                ridic = RidicTable.Select(id);
                LoadData();
            }
            return true;
        }


        private bool LoadData()
        {
            bool ret = true;

            Collection<Typ> typy = TypTable.Select();
            comboKategorie.DisplayMember = "Kategorie";
            comboKategorie.ValueMember = "pID";
            comboKategorie.DataSource = typy;

            ridic = RidicTable.Select(ridic.Uid); 

            label2.Text = ridic.Jmeno;
            BoxCislo.Text = ridic.Cislo_rp.ToString();
            BoxUlice.Text = ridic.Ulice;
            BoxMesto.Text = ridic.Mesto;
            BoxStat.Text = ridic.Stat;
            BoxObcanstvi.Text = ridic.Obcanstvi;
            CheckAktivni.Checked = ridic.Stav;

            return ret;
        }

        private bool GetNewData()
        {
            bool ret = true;
            errorProvider.Clear();
            int hodnota;

            zaznam.Uid = ridic.Uid;
            zaznam.Pid = (int)comboKategorie.SelectedValue;
            zaznam.Zid = 1; //prihlaseny zamestnanec

            if (Int32.TryParse(BoxExpirace.Text, out hodnota))
            {
                expirace = hodnota;
            }
            else
            {
                errorProvider.SetError(BoxExpirace, "Zadej správné číslo");
                ret = false;
            }

            if (Int32.TryParse(BoxCastka.Text, out hodnota))
            {
                zaznam.Castka = hodnota;
            }
            else
            {
                errorProvider.SetError(BoxCastka, "Zadej správné číslo");
                ret = false;
            }
            
            return ret;
        }

        private bool GetUpdateData()
        {
            bool ret = true;

            errorProvider.Clear();

            ridic.Ulice = BoxUlice.Text;
            ridic.Mesto = BoxMesto.Text;
            ridic.Stat = BoxStat.Text;
            ridic.Obcanstvi = BoxObcanstvi.Text;
            ridic.Stav = CheckAktivni.Checked;

            return ret;
        }

        public void GetParentForm(FormRidicGrid p)
        {
            parent = p;
        }

        public void GetDetailForm(DetailRidiceForm p)
        {
            detailForm = p;
        }

        protected bool PridatZaznam()
        {
            if(GetNewData())
            {
                ZaznamTable.NovyZaznam(zaznam, expirace);
                return true;
            }
            return false;

        }

        protected bool AktualizovatRidice()
        {
            if (GetUpdateData())
            {
                RidicTable.Update(ridic);
                return true;
            }
            return false;

        }

        private void Button_Aktualizovat_Click(object sender, EventArgs e)
        {
            if (AktualizovatRidice())
            {
                if(detailForm != null)
                    detailForm.LoadData();
                parent.RefreshData();
                Close();
            }
        }

        private void Button_zadat_Click(object sender, EventArgs e)
        {
        }

        private void Button_zadat_Click_1(object sender, EventArgs e)
        {
            if (PridatZaznam())
            {
                if (detailForm != null)
                    detailForm.LoadData();
                parent.RefreshData();
                Close();
            }
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
