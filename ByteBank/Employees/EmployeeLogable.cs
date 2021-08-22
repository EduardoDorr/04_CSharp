using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees {
  public abstract class EmployeeLogable : Employee, IVerifyLogin {
    public string Password { get; protected set; }

    public EmployeeLogable(double salary, string cpf) : base(salary, cpf) {

    }

    public void CreatePassword(string password) {
      Password = password;
    }

    public bool VerifyPassword(string password) {
      return Password == password;
    }
  }
}
