using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {
  class MacroCommand : ICommand {
    private ICommand[] _commands;
    internal MacroCommand(ICommand[] commands) {
      this._commands = commands;
    }
    public void Execute() {
      Console.WriteLine("Macro Command Executed");
      for (int i = 0; i < _commands.Length; i++) {
        _commands[i].Execute();
      }
    }
    public void Undo() {
      Console.WriteLine("Macro Command Undo");
      for (int i = 0; i < _commands.Length; i++) {
        _commands[i].Undo();
      }
    }
  }
}
