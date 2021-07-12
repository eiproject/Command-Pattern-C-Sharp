using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class AirConditionerOnCommand : ICommand {
    private AirConditioner _airConditioner;
    private int _temperature = 18;
    internal AirConditionerOnCommand(AirConditioner ac) {
      _airConditioner = ac;
    }
    void ICommand.execute() {
      _airConditioner.On();
      _airConditioner.SetTemperature(_temperature);
    }
    void ICommand.undo() {
      _airConditioner.Off();
    }
  }
}
