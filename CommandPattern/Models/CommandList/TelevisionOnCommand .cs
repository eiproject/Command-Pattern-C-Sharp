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
    void ICommand.execute() {
      _television.On();
      _television.setInputChannel(_channelNumber);
      _television.setVolume(_volume);
    }
    void ICommand.undo() {
      _television.Off();
    }
  }
}
