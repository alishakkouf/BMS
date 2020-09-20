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
    /// Interaction logic for UserControlDeleteCustomer.xaml
    /// </summary>
    public partial class UserControlDeleteCustomer : UserControl
    {
        financialContext financialContext = new financialContext();
        public UserControlDeleteCustomer()
        {
            InitializeComponent();
            customer.ItemsSource = financialContext.Employee.ToList();
            customer.SelectedValuePath = "Idemployee";
            customer.DisplayMemberPath = "Name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdDelete = int.Parse(customer.SelectedValue.ToString());
                Employee empToDelete = financialContext.Employee.FirstOrDefault(x => x.Idemployee == IdDelete);
                financialContext.Employee.Remove(empToDelete);
                financialContext.SaveChanges();
                customer.ItemsSource = financialContext.Employee.ToList();
                message.Text = "Deleted Succefully !!";
            }
            catch (Exception)
            {

                //MessageBox.Show("please select an existing employee !!", "error !!", MessageBoxButton.OK, MessageBoxImage.Error);
                customer.Focus();
                message.Text = "This customer is not exist!!";
            }
        }
    }
}
