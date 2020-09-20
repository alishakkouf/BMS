﻿using Microsoft.Win32;
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
using WpfApp1.ViewModel;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControlDashboard.xaml
    /// </summary>
    public partial class UserControlEmployees : UserControl
    {
       

        public UserControlEmployees()
        {
            InitializeComponent();

            List<job> position = Enum.GetValues(typeof(job)).Cast<job>().ToList();
            jobPosition.ItemsSource = position;

        }


        //Command="{x:Static materialDesign:DialogHost.OpenDialogCommand}"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

       
            Employee employee = new Employee();

            //employee.Name = username.Text;
            //employee.Email = email.Text;
            //employee.Phone = phone.Text;
            //employee.Job = jobPosition.SelectedItem.ToString();

           
            financialContext context = new financialContext();
            context.Employee.Add(employee);
            context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                ImageViewer.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void MedicalBrowseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
