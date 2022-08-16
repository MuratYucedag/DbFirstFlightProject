using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFirstFlightProject.Model;

namespace DbFirstFlightProject
{
    public partial class FrmPassenger : Form
    {
        public FrmPassenger()
        {
            InitializeComponent();
        }
        DbistanbulAkademiFlightEntities ent = new DbistanbulAkademiFlightEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = ent.TblPassenger.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = (from x in ent.TblPassenger
                          select new
                          {
                              x.PassengerName,
                              x.PassengerSurname
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnMenPassengerList_Click(object sender, EventArgs e)
        {
            var values = ent.TblPassenger.Where(x => x.PassengerGender == "Erkek").ToList();
            dataGridView1.DataSource = values;
        }

        private void btnWomenPassengerList_Click(object sender, EventArgs e)
        {
            var values = ent.TblPassenger.Where(x => x.PassengerGender == "Kadın");
            dataGridView1.DataSource = values.ToList();
        }

        private void FrmPassenger_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Kadın");
            cmbGender.Items.Add("Erkek");
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var totalCountPassenger = ent.TblPassenger.Count();
            lblTotalPassengerCount.Text = "Toplam Yolcu Sayısı:" + totalCountPassenger.ToString();

            var totalWomenPassenger = ent.TblPassenger.Where(x => x.PassengerGender == "Kadın").Count();
            lblWomenCount.Text = "Toplam Kadın Yolcu:" + totalWomenPassenger.ToString();

            var totalMenPassenger = ent.TblPassenger.Where(x => x.PassengerGender == "Erkek").Count();
            lblMenCount.Text = "Toplam Erkek Yolcu:" + totalMenPassenger;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblPassenger tblPassenger = new TblPassenger();
            tblPassenger.PassengerName = txtName.Text;
            tblPassenger.PassengerSurname = txtSurname.Text;
            tblPassenger.PassengerAge = txtAge.Text;
            tblPassenger.PassengerGender = cmbGender.Text;
            ent.TblPassenger.Add(tblPassenger);
            ent.SaveChanges();
            MessageBox.Show("Arkadaşlar orada mısınız");
        }
    }
}
