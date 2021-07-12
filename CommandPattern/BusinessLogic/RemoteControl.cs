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
    void IRemoteControl.SetCommand(int slot, ICommand onCommand, ICommand offCommand) {
      _onCommands[slot] = onCommand;
      _offCommands[slot] = offCommand;
    }
    void IRemoteControl.OnButtonPushed(int slot) {
      _onCommands[slot].Execute();
      _undoCommand = _onCommands[slot];
    }
    void IRemoteControl.OffButtonPushed(int slot) {
      _offCommands[slot].Execute();
      _undoCommand = _offCommands[slot];
    }
    void IRemoteControl.UndoButtonPushed() {
      Console.WriteLine("Undo button pushed:");
      _undoCommand.Undo();
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
