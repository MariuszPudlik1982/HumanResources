using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources
{
    public partial class AddEditEmployee : Form
    {
        private int _employeeId;
        private bool _pressed=false;
        private Employee _employee;
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;
            GetEmployeeData();
        }
        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych ucznia";
                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);
                if (_employee == null)
                {
                    throw new Exception("Brak użytkownika,  którego dane chcesz edytowac");
                }
                FillTextBoxes();
            }
        }
        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            tbDateOfEmployment.Text = _employee.DateOfEmployment.ToString();
            tbDateOfDismissal.Text = _employee.DateOfDismissal.ToString();
            tbAmountOfEarnings.Text = _employee.AmountOfEarnings.ToString();
            rtbComments.Text = _employee.Comments;
          
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();
            if (_employeeId!= 0)
            {
                employees.RemoveAll(x => x.Id == _employeeId);
            }
            else 
            { 
           
                AssignIdToNewEmployee(employees);
            }
            AddNewUserToList(employees);



            _fileHelper.SerializeToFile(employees);

            Close();
        }
        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var studentWithHighiestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();
            _employeeId = studentWithHighiestId == null ? 1 : studentWithHighiestId.Id + 1;
        }
        private void AddNewUserToList(List<Employee> employees)
        {
            var employee = new Employee();
            employee.Id = _employeeId;
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            try
            {
             employee.DateOfEmployment = Convert.ToDateTime(tbDateOfEmployment.Text);
             }
             catch (FormatException)
             {
              MessageBox.Show("Podałeś błedny format daty dla DateOfEmployment, oczekiwany format to dd/mm/rr lub dd-mm-rr, wprowadź prawidłowo dane aby zostały zapisane");
             }
            if (_pressed == true)
            {
                employee.DateOfDismissal = Convert.ToDateTime(tbDateOfDismissal.Text);
            }
            else
            {
                employee.DateOfDismissal = null;
            }


            try
            {
                employee.AmountOfEarnings = decimal.Parse(tbAmountOfEarnings.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Podałeś nieprawidłową wartość wypłaty lub nie podałeś wogóle wypłaty, aby dane zostały zapisane wprowadź je prawidłowo");
            }
            
            employee.Comments = rtbComments.Text;
            if (employee.DateOfEmployment!=null && employee.AmountOfEarnings!=null)
            {
                employees.Add(employee);
            }
            
        }
        private void btnDismiss_Click(object sender, EventArgs e)
        {
        
            
           if (Text== "Edytowanie danych ucznia")
            {
                _pressed = true;
                tbDateOfDismissal.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Przycisk jest nieaktywny gdyż jesteś w trybie dodawania nowego pracownika");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

