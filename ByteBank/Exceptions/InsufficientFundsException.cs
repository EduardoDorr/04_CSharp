using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
  class InsufficientFundsException : FinancialOperationException {
    public double Balance { get; }
    public double Withdraw { get; }

    public InsufficientFundsException() {

    }

    public InsufficientFundsException(double balance, double value)
      : this("Attempt to withdraw $" + value + " into an account with balance of $" + balance + "!") {
      Balance = balance;
      value = Withdraw;

    }

    public InsufficientFundsException(string message)
      : base(message) {

    }

    public InsufficientFundsException(string message, Exception innerException)
      : base(message, innerException) {

    }
  }
}
