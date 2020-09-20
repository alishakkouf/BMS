using System;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (username.Text == "ali" && password.Password == "0000")
                {
                    Window newForm = new MainWindow(); //create your new form.
                    newForm.Show(); //show the new form.
                    this.Close(); //only if you want to close the current form.
                }
                else
                {
                    MessageBox.Show("please try again with correct info !!", "error !!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("please try again with correct info !!", "error !!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
