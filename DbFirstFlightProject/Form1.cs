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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbistanbulAkademiFlightEntities ent = new DbistanbulAkademiFlightEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.TblCity.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCity tblCity = new TblCity();
            tblCity.CityName = txtCityName.Text;
            tblCity.CityCountry = txtCountryName.Text;
            ent.TblCity.Add(tblCity);
            ent.SaveChanges();
            MessageBox.Show("Şehir başarılı bir şekilde eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //lambda 
            //x=>x.
            int id = Convert.ToInt32(txtCityID.Text);
            var values = ent.TblCity.Where(x => x.CityID == id).FirstOrDefault();
            ent.TblCity.Remove(values);
            ent.SaveChanges();
            MessageBox.Show("Kayıt başarılı bir şekilde silindi");
        }

        private void btnSearchByCity_Click(object sender, EventArgs e)
        {
            //var values = ent.TblCity.ToList();
            //dataGridView1.DataSource = values;
            string cityName = txtCityName.Text;
            var values = ent.TblCity.Where(y => y.CityName == cityName).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCityID.Text);
            var values = ent.TblCity.Where(x => x.CityID == id).FirstOrDefault();
            values.CityName=txtCityName.Text;
            values.CityCountry = txtCountryName.Text;
            ent.SaveChanges();
            MessageBox.Show("Bilgiler başarılı bir şekilde güncellendi");
        }
    }
}
