using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class LightOffCommand : ICommand {
    private Light _light;
    internal LightOffCommand(Light light) {
      _light = light;

    }
    void ICommand.execute() {
      _light.Off();
    }

    void ICommand.undo() {
      throw new NotImplementedException();
    }
  }
}
