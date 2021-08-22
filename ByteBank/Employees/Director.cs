using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees {
  public class Director : EmployeeLogable {
    public Director(string cpf) : base(5000, cpf) {

    }

    public override void RiseSalary() {
      Salary *= 1.15;
    }

    public override double GetBonus() {
      return Salary * 0.5;
    }
  }
}
