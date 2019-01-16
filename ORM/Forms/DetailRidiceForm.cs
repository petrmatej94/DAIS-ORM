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
    public partial class DetailRidiceForm : Form
    {
        Ridic ridic = new Ridic();
        FormRidicGrid parent;

        public DetailRidiceForm()
        {
            InitializeComponent();
        }


        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int id = (int)primaryKey;
                ridic = RidicTable.Select(id);
                LoadData();
            }
            return true;
        }


        public bool LoadData()
        {
            ridic = RidicTable.Select(ridic.Uid);

            JmenoLabel.Text = ridic.Jmeno;
            BoxUlice.Text = ridic.Ulice;
            BoxMesto.Text = ridic.Mesto;
            BoxStat.Text = ridic.Stat;
            BoxObcanstvi.Text = ridic.Obcanstvi;
            BoxDatum.Text = ridic.Datum_narozeni.ToString();
            BoxCislo.Text = ridic.Cislo_rp.ToString();
            BoxPlatnost.Text = ridic.Platnost_rp.ToString();
            BoxPocet.Text = ridic.Pocet_bodu.ToString();
            CheckAktivni.Checked = ridic.Stav;


            Collection<Skupina> skupiny = SkupinaTable.SelectRidic(ridic.Uid);

            foreach(Skupina skupina in skupiny)
            {
                listBox1.Items.Add("  " + skupina.skupina + "\t-\t" + skupina.Popis);
            }
            return true;
        }


        public void GetParentForm(FormRidicGrid p)
        {
            parent = p;
        }

        private void Aktualizace_Click(object sender, EventArgs e)
        {
            Forms.AktualizaceRidiceForm form = new Forms.AktualizaceRidiceForm();
            form.GetParentForm(parent);
            form.GetDetailForm(this);
            if (form.OpenRecord(ridic.Uid))
            {
                form.MdiParent = this.ParentForm;
                form.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NovyZaznam_Click(object sender, EventArgs e)
        {
            Aktualizace_Click(sender, e);
        }

        private void ZobrazZaznamy_Click(object sender, EventArgs e)
        {
            Forms.ZaznamGridForm form = new Forms.ZaznamGridForm();
            if (form.OpenRecord(ridic.Uid))
            {
                form.MdiParent = this.ParentForm;
                form.Show();
            }
        }

        private void ZobrazVozidla_Click(object sender, EventArgs e)
        {
            Forms.VozidlaRidiceGridForm form = new Forms.VozidlaRidiceGridForm();

            if (form.OpenRecord(ridic.Uid))
            {
                form.MdiParent = this.ParentForm;
                form.Show();
            }
        }
    }
}
