using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees {
  public class Dev : Employee {
    public Dev(string cpf) : base(3000, cpf) {

    }

    public override void RiseSalary() {
      Salary *= 0.15;
    }

    public override double GetBonus() {
      return Salary * 0.1;
    }
  }
}
