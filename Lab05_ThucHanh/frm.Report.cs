using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_ThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            List<Student> listStudent = GetTempListStudent();
            ReportDataSource rds = new ReportDataSource("dataSetStudent", listStudent); 
            this.reportViewer1.LocalReport.DataSources.Clear(); this.reportViewer1.LocalReport.DataSources.Add(rds); this.reportViewer1.RefreshReport();

        }

        public List<Student> GetTempListStudent()
        {
            List<Student> listStudent = new List<Student>(); for (int i = 0; i < 10; i++)
            {
                Student temp = new Student(); temp.StudentID = "CNTT0120" + i; temp.FullName = "Nguyen Van" + i; temp.BirthDay = new DateTime(2000, 1, 1); temp.Address = "Dia chi" + i;
                listStudent.Add(temp);
            }
            return listStudent;
        }
        
    }
}
