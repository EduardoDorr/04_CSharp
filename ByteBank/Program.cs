using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
  class Program {
    static void Main(string[] args) {
      //ComputeBonus();
      //UseInternalSystem();
      //TestDivision();
      //TestInnerException();

      try {
        LoadAccounts();
      }
      catch (Exception) {

        Console.WriteLine("Catch occured on Main!");
      }
     
      Console.WriteLine("The application finished. Key enter to exit.");
      Console.ReadLine();
    }

    public static void LoadAccounts() {
      using (FileReader file = new FileReader("account.txt")) {
        file.ReadLine();
        file.ReadLine();
        file.ReadLine();
      }

      //FileReader file = null;

      //try {
      //  file = new FileReader("account.txt");

      //  file.ReadLine();
      //  file.ReadLine();
      //  file.ReadLine();
      //}
      //catch (IOException e) {

      //  Console.WriteLine(e.Message);
      //}
      //finally {
      //  if (file != null) {
      //    file.CloseFile();
      //  }
      //}
    }

    public static void TestInnerException() {
      try {
        CheckingAccount accountRobert = new CheckingAccount(456, 251845);
        CheckingAccount accountBob = new CheckingAccount(456, 251648);

        accountRobert.Withdraw(255);
        Console.WriteLine("Actual Robert's balance: " + accountRobert.Balance);
        Console.WriteLine("Actual bob's balance: " + accountBob.Balance);
      }
      catch (FinancialOperationException e) {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
        Console.WriteLine("A FinancialOperationException occurred!!");
      }
      catch (ArgumentException e) {
        Console.WriteLine(e.Message);
        Console.WriteLine("Problem with argument: " + e.ParamName);
        Console.WriteLine("A ArgumentException occurred!!");
      }
      catch (DivideByZeroException e) {
        Console.WriteLine(e.Message);
        Console.WriteLine("A DivideByZeroException occurred!!");
      }
      catch (Exception e) {
        Console.WriteLine(e.Message);
      }
    }

    public static void TestDivision() {
      try {
        //TestDivision(2);
        TestDivision(0);
      }
      catch (DivideByZeroException e) {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
        Console.WriteLine("It's not possible to divide a number per zero!!");
      }
      catch (Exception e) {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
        Console.WriteLine("A error occurred!!");
      }
    }

    public static void TestDivision(int divider) {
      int result = Divide(10, divider);

      Console.WriteLine("The division's result of 10 per " + divider + " is " + result);
    }

    public static int Divide(int dividend, int divider) {
      try {
        return dividend / divider;
      }
      catch (DivideByZeroException) {

        Console.WriteLine("Exception with dividend " + dividend + " and divider " + divider);
        throw;
      }
    }

    public static void ComputeBonus() {
      GetBonus manager = new GetBonus();

      Designer john = new Designer("458.854.215-78");
      john.Name = "John";

      Director robert = new Director("014.312.466-15");
      robert.Name = "Robert";

      AccountManager bob = new AccountManager("214.698.854-25");
      bob.Name = "Bob";

      Dev ruri = new Dev("589.325.754-46");
      ruri.Name = "Ruri";

      Auxiliary bill = new Auxiliary("023.675.359-46");
      bill.Name = "Bill";

      manager.Register(john);
      manager.Register(robert);
      manager.Register(bob);
      manager.Register(bill);
      manager.Register(ruri);

      Console.WriteLine("Total bonus on last month: " + manager.GetBonusTotal());
    }

    public static void UseInternalSystem() {
      InternSystem internSystem = new InternSystem();

      Director robert = new Director("014.312.466-15");
      robert.Name = "Robert";
      robert.CreatePassword("123");

      AccountManager bob = new AccountManager("214.698.854-25");
      bob.Name = "Bob";
      bob.CreatePassword("abc");

      ComercialPartner partner = new ComercialPartner();
      partner.CreatePassword("456");
      
      internSystem.Login(robert, "123");
      internSystem.Login(bob, "abd");
      internSystem.Login(partner, "456");      
    }
  }
}
