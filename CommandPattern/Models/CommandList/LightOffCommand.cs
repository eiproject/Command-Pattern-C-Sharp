using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class LightOffCommand : ICommand {
    private Light _light;
    internal LightOffCommand(Light light) {
      _light = light;

    }
    void ICommand.Execute() {
      _light.Off();
    }

    void ICommand.Undo() {
      _light.On();
    }
  }
}
