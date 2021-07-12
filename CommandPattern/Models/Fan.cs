using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models {
  class Fan : ICommand {
    void ICommand.execute() {
      throw new NotImplementedException();
    }

    void ICommand.undo() {
      throw new NotImplementedException();
    }
  }
}
