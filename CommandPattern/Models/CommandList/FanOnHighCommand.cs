using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class FanOnHighCommand : ICommand {
    private Fan _fan;
    private int _prevSpeed;
    internal FanOnHighCommand(Fan fan) {
      _fan = fan;
    }
    void ICommand.Execute() {
      _prevSpeed = _fan.GetSpeed();
      _fan.High();
    }

    void ICommand.Undo() {
      if (_prevSpeed == (int)FanSpeed.HIGH) {
        _fan.High();
      }
      else if (_prevSpeed == (int)FanSpeed.MEDIUM) {
        _fan.Medium();
      }
      else if (_prevSpeed == (int)FanSpeed.LOW) {
        _fan.Low();
      }
      else if (_prevSpeed == (int)FanSpeed.OFF) {
        _fan.Off();
      }
    }
  }
}
