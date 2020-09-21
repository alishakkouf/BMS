using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        
            public MainWindow()
            {
                InitializeComponent();

                var menuRegister = new List<SubItem>();
                menuRegister.Add(new SubItem("Add Employeee", new UserControlEmployees()));
                menuRegister.Add(new SubItem("Delete Employee", new UserControlDeletEmployees()));
                menuRegister.Add(new SubItem("All Employees", new UserControlDisplayAll()));
                menuRegister.Add(new SubItem("Update Employee" , new UpdateEmployee()));
                var item6 = new ItemMenu("Employees", menuRegister, PackIconKind.Register);

                var menuSchedule = new List<SubItem>();
                menuSchedule.Add(new SubItem("Add Course",new UserControlAddCourse()));
                menuSchedule.Add(new SubItem("Assign Course", new UserControlAssignCourse()));
            menuSchedule.Add(new SubItem("Display Registered Courses", new UserControlDisplayRegisteredCourses()));
            menuSchedule.Add(new SubItem("Display Assigned Courses", new UserControlDisplayAssignedCourses()));
            menuSchedule.Add(new SubItem("Update Course", new UserControlUpdateCourse()));
            menuSchedule.Add(new SubItem("Delete Course", new UserControlDeleteCourse()));
            menuSchedule.Add(new SubItem("Update Assigned Course", new UserControlUpdateAssignedCourse()));
            menuSchedule.Add(new SubItem("Delete Assigned Course", new UserControlDeleteAssignedCourse()));
            var item1 = new ItemMenu("Courses", menuSchedule, PackIconKind.Schedule);

                var menuReports = new List<SubItem>();
                menuReports.Add(new SubItem("Add Customer" , new UserControlAddCustomer()));
                menuReports.Add(new SubItem("Delete Customer" , new UserControlDeleteCustomer()));
                menuReports.Add(new SubItem("Update Customer", new UserControlUpdateCustomer()));
            menuReports.Add(new SubItem("Update Customer", new UserControlUpdateCustomer()));
            menuReports.Add(new SubItem("Display Customer" , new UserControlDisplayCustomer()));
                var item2 = new ItemMenu("Customers", menuReports, PackIconKind.FileReport);

                var menuExpenses = new List<SubItem>();
                menuExpenses.Add(new SubItem("Fixed"));
                menuExpenses.Add(new SubItem("Variable"));
                var item3 = new ItemMenu("Expenses", menuExpenses, PackIconKind.ShoppingBasket);

                var menuFinancial = new List<SubItem>();
                menuFinancial.Add(new SubItem("Cash flow"));
                var item4 = new ItemMenu("Financial", menuFinancial, PackIconKind.ScaleBalance);

                Menu.Children.Add(new UserControlMenuItem(item6, this));
                Menu.Children.Add(new UserControlMenuItem(item1, this));
                Menu.Children.Add(new UserControlMenuItem(item2, this));
                Menu.Children.Add(new UserControlMenuItem(item3, this));
                Menu.Children.Add(new UserControlMenuItem(item4, this));
            }

            internal void SwitchScreen(object sender)
            {
                var screen = ((UserControl)sender);

                if (screen != null)
                {
                    StackPanelMain.Children.Clear();
                    StackPanelMain.Children.Add(screen);
                }
            }
        }
    }

