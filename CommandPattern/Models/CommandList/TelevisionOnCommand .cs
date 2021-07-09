using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class TelevisionOnCommand : ICommand {
    private Television _television;
    private int _savedChannelNumber = 2;
    private int _savedVolume = 5;
    internal TelevisionOnCommand(Television television) {
      _television = television;
    }
    void ICommand.execute() {
      _television.On();
      _television.setInputChannel(_savedChannelNumber);
      _television.setVolume(_savedVolume);
    }
    void ICommand.undo() {
      
    }
  }
}
