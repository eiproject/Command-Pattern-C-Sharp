using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {

  class RemoteControl : IRemoteControl{
    private int _numOfKey; 
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;
    private ICommand _undoCommand;
    private StringBuilder _remoteCondition;

    internal RemoteControl(int numOfKey) {
      _numOfKey = numOfKey;

      _onCommands = new ICommand[_numOfKey];
      _offCommands = new ICommand[_numOfKey];

      ICommand noCommand = new NoCommand();
      for (int i = 0; i < _numOfKey; i++) {
        _onCommands[i] = noCommand;
        _offCommands[i] = noCommand;
      }
    }
    void IRemoteControl.setCommand(int slot, ICommand onCommand, ICommand offCommand) {
      _onCommands[slot] = onCommand;
      _offCommands[slot] = offCommand;
    }
    void IRemoteControl.onButtonPushed(int slot) {
      _onCommands[slot].execute();
      _undoCommand = _onCommands[slot];
    }
    void IRemoteControl.offButtonPushed(int slot) {
      _offCommands[slot].execute();
      _undoCommand = _offCommands[slot];
    }
    void IRemoteControl.undoButtonPushed() {
      _undoCommand.undo();
    }

    StringBuilder IRemoteControl.ViewRemoteCondition() {
      _remoteCondition = new StringBuilder();
      _remoteCondition.Append("Current Remote: \n");
      for (int i = 0; i < _numOfKey; i++) {
        _remoteCondition.Append("[slot "+ i +"]" + _onCommands[i].ToString() +"    " + _offCommands[i].ToString() + "\n");
      }

      return _remoteCondition;
    }
  }
}
