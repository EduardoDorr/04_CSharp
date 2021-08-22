using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
  class FileReader : IDisposable {
    public string File { get; }

    public FileReader(string file) {
      File = file;

      //throw new FileNotFoundException();

      Console.WriteLine("Opening file.");
    }

    public string ReadLine() {
      Console.WriteLine("Reading line . . .");

      //throw new IOException();

      return "!";
    }

    public void Dispose() {
      Console.WriteLine("Closing file.");
    }
  }
}
