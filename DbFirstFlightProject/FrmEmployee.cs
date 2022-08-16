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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        //Eager Load - Lazy Load

        DbistanbulAkademiFlightEntities ent = new DbistanbulAkademiFlightEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = from x in ent.TblEmployee
                         select new
                         {
                             ID = x.EmployeeID,
                             Personel_Adı = x.EmployeeName,
                             Departmanı = x.TblDepartment.DepartmentName,
                             Maaş = x.EmployeeSalary
                         };
            dataGridView1.DataSource = values.ToList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "DepartmentName";
            comboBox1.ValueMember = "DepartmentID";
            comboBox1.DataSource = ent.TblDepartment.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblEmployee tblEmployee = new TblEmployee();
            tblEmployee.EmployeeName = txtName.Text;
            tblEmployee.EmployeeDepartment = int.Parse(comboBox1.SelectedValue.ToString());
            ent.TblEmployee.Add(tblEmployee);
            ent.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var totalCountEmployee = ent.TblEmployee.Count();
            lblTotalCount.Text = totalCountEmployee.ToString();

            var totalSalary = ent.TblEmployee.Sum(x => x.EmployeeSalary);
            lblSumSalary.Text = totalSalary.ToString();

            var avgSalary = ent.TblEmployee.Average(x => x.EmployeeSalary);
            lblAvgSalary.Text = avgSalary.ToString();

            var maxSalary = ent.TblEmployee.Max(x => x.EmployeeSalary);
            lblMaxSalary.Text = maxSalary.ToString();

            var maxHaveSalary = ent.TblEmployee.Max(x => x.EmployeeSalary);
            lblMaxSalaryEmployee.Text = ent.TblEmployee.Where(x => x.EmployeeSalary == maxHaveSalary).FirstOrDefault().EmployeeName;
        }
    }
}