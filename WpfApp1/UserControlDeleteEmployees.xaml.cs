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
using MaterialSkin;
using MaterialSkin.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControlProviders.xaml
    /// </summary>
    public partial class UserControlDeletEmployees : UserControl 
    {
        financialContext financialContext = new financialContext();
        public UserControlDeletEmployees()
        {

            InitializeComponent();


          
            
               emp.ItemsSource = financialContext.Employee.ToList();
                emp.SelectedValuePath = "Idemployee";
                emp.DisplayMemberPath = "Name";
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdDelete = int.Parse(emp.SelectedValue.ToString());
                Employee empToDelete = financialContext.Employee.FirstOrDefault(x => x.Idemployee == IdDelete);
                financialContext.Employee.Remove(empToDelete);
                financialContext.SaveChanges();
                emp.ItemsSource = financialContext.Employee.ToList();
                message.Text = "Deleted Succefully !!";
            }
            catch (Exception)
            {

             //MessageBox.Show("please select an existing employee !!", "error !!", MessageBoxButton.OK, MessageBoxImage.Error);
                emp.Focus();
                 message.Text = "This employee is not exist!!";
            }
        }
    }
}
