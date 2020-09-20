using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UpdateEmployee.xaml
    /// </summary>
    public partial class UpdateEmployee : UserControl
    {
        financialContext financialContext = new financialContext();
        public int idForUpdate;
        public UpdateEmployee()
        {
            InitializeComponent();
            emp.ItemsSource = financialContext.Employee.ToList();
            emp.SelectedValuePath = "Idemployee";
            emp.DisplayMemberPath = "Name";

        }

        private void Emp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            idForUpdate = int.Parse(emp.SelectedValue.ToString());
            Employee empToUpdate = financialContext.Employee.FirstOrDefault(x => x.Idemployee == idForUpdate);
            List<Employee> empSelected = new List<Employee>();
            empSelected.Add(empToUpdate);
            allEmployee.ItemsSource = empSelected;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
          
            //TextBlock CellContent = DataGrid.SelectedCells[ColumnIndex].Column.GetCellContent(DataGrid.SelectedItem);
            TextBlock NameEmpl = allEmployee.Columns[1].GetCellContent(allEmployee.Items[0]) as TextBlock;
            string Name1 = NameEmpl.Text;
            TextBlock job = allEmployee.Columns[2].GetCellContent(allEmployee.Items[0]) as TextBlock;
            string job1 = job.Text;
            TextBlock phone = allEmployee.Columns[3].GetCellContent(allEmployee.Items[0]) as TextBlock;
            string phone1 = phone.Text;
            TextBlock email = allEmployee.Columns[4].GetCellContent(allEmployee.Items[0]) as TextBlock;
            string email1 = email.Text;


            Employee empToUpdate = financialContext.Employee.FirstOrDefault(x => x.Idemployee == idForUpdate);

            empToUpdate.Name = Name1;
            empToUpdate.Job = job1;
            empToUpdate.Phone = phone1;
            empToUpdate.Email = email1;

            financialContext.Employee.Update(empToUpdate);
            financialContext.SaveChanges();
            message.Text = "Updatet Successfully !!";


            }
            catch (Exception)
            {

                message.Text = "Please try again !!";
            }




        }
    }
}
