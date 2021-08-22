using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees {
  class GetBonus {
    private double _bonusTotal;

    public void Register(Employee employee) {
      _bonusTotal += employee.GetBonus();
    }

    public double GetBonusTotal() {
      return _bonusTotal;
    }
  }
}
