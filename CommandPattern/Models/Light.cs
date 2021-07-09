using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Light {
    private string _itemName = "Light";
    private bool _isOnStatus = false;
    void On() {
      _isOnStatus = true;
    }
    void Off() {
      _isOnStatus = false;
    }
    void Status() {
      if (_isOnStatus) {
        Console.WriteLine(_itemName + " ON");
      }
      else {
        Console.WriteLine(_itemName + " OFF");
      }
    }
  }
}
