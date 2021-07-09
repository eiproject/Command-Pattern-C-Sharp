using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class AirConditioner {
    private string _itemName = "Air Conditioner";
    private float _temperature;
    private bool _isOnStatus = false;

    void On() {
      _isOnStatus = true;
    }
    void Off() {
      _isOnStatus = false;
    }
    void SetTemperature(float temp) {

    }
    void Status() {
      if (_isOnStatus) {
        Console.WriteLine(_itemName + " is ON");
      }
      else {
        Console.WriteLine(_itemName + " is OFF");
      }
      
    }
  }
}
