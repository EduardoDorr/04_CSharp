using System;

namespace ByteBank {
  public class CheckingAccount {
    private double _balance = 100;

    public Client Owner { get; set; }
    public static double OperationTax { get; private set; }
    public static int Qtd { get; private set; }
    public int Agency { get; }
    public int Number { get; }
    public double Balance {
      get {
        return _balance;
      }
      set {
        if (value < 0) {
          return;
        }

        _balance = value;
      }
    }
    public int WithdrawNotAllowed { get; private set; }
    public int TransferNotAllowed { get; private set; }

    public CheckingAccount(int agency, int number) {
      if (agency <= 0) {
        throw new ArgumentException("Agency and Number must be greater than 0", nameof(agency));
      }

      if (number <= 0) {
        throw new ArgumentException("Agency and Number must be greater than 0", nameof(number));
      }

      Agency = agency;
      Number = number;

      Qtd++;
      OperationTax = 30 / Qtd;
    }

    public void Withdraw(double value) {
      if (value < 0) {
        throw new ArgumentException("The withdraw value is invalid!", nameof(value));
      }
      if (_balance < value) {
        WithdrawNotAllowed++;
        throw new InsufficientFundsException(_balance, value);
      }
      _balance -= value;
    }

    public void Deposit(double value) {
      _balance += value;
    }

    public void Transfer(double value, CheckingAccount destAccount) {
      if (value < 0) {
        throw new ArgumentException("The transfer value is invalid!", nameof(value));
      }
      try {
        Withdraw(value);
      }
      catch (InsufficientFundsException ex) {
        throw new FinancialOperationException("The operation couldn't be performed", ex);
      }
      destAccount.Deposit(value);
    }
  }
}