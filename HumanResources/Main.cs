using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources
{
    public partial class Main : Form
    {
        //private string _filePath = Path.Combine(Environment.CurrentDirectory, "students.txt");

        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        public Main()
        {
            InitializeComponent();
            RefreshList();
            SetColumnsHeader();
        }

        void RefreshList()
        {
            var _employees = _fileHelper.DeserializeFromFile();
            dgvList.DataSource = _employees;
        }
        private void SetColumnsHeader()
        {
            dgvList.Columns[0].HeaderText = "Numer";
            dgvList.Columns[1].HeaderText = "Imie";
            dgvList.Columns[2].HeaderText = "Nazwisko";
            dgvList.Columns[3].HeaderText = "Data Zatrudnienia";
            dgvList.Columns[4].HeaderText = "Data zwolnienia z pracy";
            dgvList.Columns[5].HeaderText = "Kwota wypłaty";
            dgvList.Columns[6].HeaderText = "Uwagi";
           
        }
        private void btnDismis_Click(object sender, EventArgs e)
        {
            var employee = _fileHelper.DeserializeFromFile();
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
               var addEditEmployee = new AddEditEmployee();
               addEditEmployee.ShowDialog();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz ucznia, którego dane chcesz edytowac");
                return;
            }
            var addEditStudent = new AddEditEmployee(Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value));
            addEditStudent.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
