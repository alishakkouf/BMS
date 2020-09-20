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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControlAddCourse.xaml
    /// </summary>
    public partial class UserControlAddCourse : UserControl
    {
        public UserControlAddCourse()
        {
            InitializeComponent();
            List<CourseType> position = Enum.GetValues(typeof(CourseType)).Cast<CourseType>().ToList();
            CourseType.ItemsSource = position;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
