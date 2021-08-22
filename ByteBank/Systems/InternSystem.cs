using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems {
  public class InternSystem {
    public bool Login(IVerifyLogin employee, string password) {
      bool logable = employee.VerifyPassword(password);

      if (logable) {
        Console.WriteLine("Welcome to ByteBank System!");
        return true;
      }

      Console.WriteLine("Password is incorrect!");
      return false;
    }
  }
}
