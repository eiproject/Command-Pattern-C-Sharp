using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class TelevisionOffCommand : ICommand {
    private Television _television;
    internal TelevisionOffCommand(Television television) {
      _television = television;
    }
    void ICommand.Execute() {
      _television.Off();
    }
    void ICommand.Undo() {
      _television.On();
    }
  }
}
