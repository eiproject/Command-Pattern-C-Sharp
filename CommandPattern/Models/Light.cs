using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Light {
    private string _itemName = "Light";
    private bool _isOnStatus = false;
    internal void On() {
      _isOnStatus = true;
      Status();
    }
    internal void Off() {
      _isOnStatus = false;
      Status();
    }
    internal void Status() {
      if (_isOnStatus) {
        Console.WriteLine(_itemName + " ON");
      }
      else {
        Console.WriteLine(_itemName + " OFF");
      }
    }
  }
}
