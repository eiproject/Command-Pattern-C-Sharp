using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {

  class RemoteControl {
    private const int _numOfKey = 5; 
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;

    internal RemoteControl() {
      _onCommands = new Command[_numOfKey];
      _offCommands = new Command[_numOfKey];

      ICommand noCommand = new NoCommand();
      for (int i = 0; i < _numOfKey; i++) {
        _onCommands[i] = noCommand;
        _offCommands[i] = noCommand;
      }
    }
    void setCommand(int slot, ICommand onCommand, ICommand offCommand) {
      _onCommands[slot] = onCommand;
      _offCommands[slot] = offCommand;
    }
  }
}
