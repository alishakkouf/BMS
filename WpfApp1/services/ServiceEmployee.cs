using WpfApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel;

namespace WpfApp1.services
{
    public class ServicesEmployee : Interfaces.IEmployee
    {
        private readonly financialContext _context;

        public ServicesEmployee()
        {
        }

        public ServicesEmployee(financialContext context)
        {
            _context = context;
        }
    
        public async void AddEmployee(Employee employee)
        {
            if (_context != null)
            {
              await  _context.Employee.AddAsync(employee);
              await  _context.SaveChangesAsync();
            }
        }
    }
}
