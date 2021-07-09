using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Television {
    private string _itemName = "Television";
    private int _channelNumber;
    private int _volume;
    private bool _isOnStatus = false;

    void On() {
      _isOnStatus = true;
    }
    void Off() {
      _isOnStatus = false;
    }

    void setInputChannel(int channelNumber) {
      _channelNumber = channelNumber;
    }
    void setVolume(int volume) {
      _volume = volume;
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
