using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for UserControlUpdateCustomer.xaml
    /// </summary>
    public partial class UserControlUpdateCustomer : UserControl
    {
        financialContext financialContext = new financialContext();
        public int idForUpdate;
        public UserControlUpdateCustomer()
        {
            InitializeComponent();
            customer.ItemsSource = financialContext.Employee.ToList();
            customer.SelectedValuePath = "Idemployee";
            customer.DisplayMemberPath = "Name";
        }

        private void Emp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            idForUpdate = int.Parse(customer.SelectedValue.ToString());
            Employee empToUpdate = financialContext.Employee.FirstOrDefault(x => x.Idemployee == idForUpdate);
            List<Employee> empSelected = new List<Employee>();
            empSelected.Add(empToUpdate);
            allEmployee.ItemsSource = empSelected;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
