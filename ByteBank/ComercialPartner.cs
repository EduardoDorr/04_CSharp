using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
  public class ComercialPartner : IVerifyLogin {
    public string Password { get; private set; }

    public void CreatePassword(string password) {
      Password = password;
    }

    public bool VerifyPassword(string password) {
      return Password == password;
    }
  }
}
