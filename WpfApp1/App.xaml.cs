using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

            private void ConfigureServices(ServiceCollection services)
            {
                services.AddDbContextPool<financialContext>(options =>
                {
                    options.UseMySql("Server=localhost;Database=financial;UID=root;PWD=0935479586;");
                });
                services.AddSingleton<MainWindow>();
            
        }

    
    
}
}
