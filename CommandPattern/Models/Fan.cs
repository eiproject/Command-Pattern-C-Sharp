using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  enum FanSpeed {
    OFF,
    LOW,
    MEDIUM,
    HIGH
  }
  class Fan {
    private string _itemName = "Fan";
    private int _fanSpeed;
    private bool _isOnStatus = false;

    internal Fan(string detail) {
      _itemName += $" on { detail }";
    }
    internal void High() {
      _isOnStatus = true;
      _fanSpeed = (int)FanSpeed.HIGH;
      Status();
    }
    internal void Medium() {
      _isOnStatus = true;
      _fanSpeed = (int)FanSpeed.MEDIUM;
      Status();
    }
    internal void Low() {
      _isOnStatus = true;
      _fanSpeed = (int)FanSpeed.LOW;
      Status();
    }
   /* internal void On() {
      _isOnStatus = true;
      Status();
    }*/
    internal void Off() {
      _fanSpeed = (int)FanSpeed.OFF;
      _isOnStatus = false;
      Status();
    }
    internal void Status() {
      if (_isOnStatus) {
        Console.WriteLine(_itemName + " ON " + _fanSpeed.ToString());
      }
      else {
        Console.WriteLine(_itemName + " OFF " + _fanSpeed.ToString());
      }
    }
    internal int GetSpeed() {
      return _fanSpeed;
    }
  }
}
