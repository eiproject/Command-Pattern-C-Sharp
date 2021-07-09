using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class LightOnCommand : ICommand {
    private Light _light;
    internal LightOnCommand(Light light) {
      _light = light;

    }
    void ICommand.execute() {
      _light.On();
    }

    void ICommand.undo() {
      throw new NotImplementedException();
    }
  }
}
