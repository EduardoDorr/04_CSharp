using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees {
  public abstract class Employee {
    public static int Qtd { get; set; }
    public string Name { get; set; }
    public string CPF { get; private set; }
    public double Salary { get; protected set; }

    public Employee(double salary, string cpf) {
      Salary = salary;
      CPF = cpf;

      Qtd++;
    }

    public abstract void RiseSalary();

    public abstract double GetBonus();
  }
}
