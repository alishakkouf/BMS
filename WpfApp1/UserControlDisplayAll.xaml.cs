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
    /// Interaction logic for AllUserControl1.xaml
    /// </summary>
    public partial class UserControlDisplayAll : UserControl
    {
        financialContext financialContext = new financialContext();
        public UserControlDisplayAll()
        {
            InitializeComponent();

            allEmployee.ItemsSource = financialContext.Employee.ToList();
          
        }
    }
}
