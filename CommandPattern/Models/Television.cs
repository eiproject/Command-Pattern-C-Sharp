using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Television {
    private string _itemName = "Television";
    private int _channelNumber;
    private int _volume;
    private bool _isOnStatus = false;

    internal void On() {
      _isOnStatus = true;
      Status();
    }
    internal void Off() {
      _isOnStatus = false;
      Status();
    }

    internal void setInputChannel(int channelNumber) {
      _channelNumber = channelNumber;
    }
    internal void setVolume(int volume) {
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
