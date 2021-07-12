using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class AirConditioner {
    private string _itemName = "Air Conditioner";
    private float _temperature;
    private bool _isOnStatus = false;
    internal AirConditioner(string detail) {
      _itemName += $" on { detail }";
    }
    internal void On() {
      _isOnStatus = true;
      SetTemperature(18);
      Status();
    }
    internal void Off() {
      _isOnStatus = false;
      Status();
    }
    internal void SetTemperature(float temp) {
      _temperature = temp;
    }
    internal void Status() {
      if (_isOnStatus) {
        Console.WriteLine(_itemName + " is ON");
      }
      else {
        Console.WriteLine(_itemName + " is OFF");
      }
      
    }
  }
}
