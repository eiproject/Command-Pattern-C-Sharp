using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Television {
    private string _itemName = "Television";
    private int _channelNumber;
    private int _volume;
    private bool _isOnStatus = false;
    internal Television(string detail) {
      _itemName += $" on { detail }";
    }
    internal void On() {
      _isOnStatus = true;
      SetInputChannel(1);
      SetVolume(5);
      Status();
    }
    internal void Off() {
      _isOnStatus = false;
      Status();
    }

    internal void SetInputChannel(int channelNumber) {
      _channelNumber = channelNumber;
    }
    internal void SetVolume(int volume) {
      _volume = volume;
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
