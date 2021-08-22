using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees {
  public class Auxiliary : Employee {
    public Auxiliary(string cpf) : base(2000, cpf) {

    }

    public override void RiseSalary() {
      Salary *= 1.1;
    }

    public override double GetBonus() {
      return Salary * 0.2;
    }
  }
}
