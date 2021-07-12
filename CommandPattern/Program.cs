using System;

namespace CommandPattern {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello Command Pattern! Remote.");
      Run Remote = new Run();
      Remote.RemoteLoader();
    }
  }
}
