using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class TelevisionOnCommand : ICommand {
    private Television _television;
    private int _channelNumber = 2;
    private int _volume = 5;
    internal TelevisionOnCommand(Television television) {
      _television = television;
    }
    void ICommand.Execute() {
      _television.On();
      _television.SetInputChannel(_channelNumber);
      _television.SetVolume(_volume);
    }
    void ICommand.Undo() {
      _television.Off();
    }
  }
}
