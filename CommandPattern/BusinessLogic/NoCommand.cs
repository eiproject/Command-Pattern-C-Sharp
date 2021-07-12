using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {
  class NoCommand : ICommand {
    void ICommand.Execute() {}
    void ICommand.Undo() {}
  }
}
