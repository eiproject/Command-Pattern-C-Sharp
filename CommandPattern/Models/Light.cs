using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Light {
    private string _itemName = "Light"
    void On() {
      Console.WriteLine(_itemName);
    }

    void Off() {

    }
  }
}
