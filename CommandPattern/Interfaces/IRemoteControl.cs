using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {
  interface IRemoteControl {
    void setCommand(int slot, ICommand onCommand, ICommand offCommand);
    void onButtonPushed(int slot);
    void offButtonPushed(int slot);
    void undoButtonPushed();
    StringBuilder ViewRemoteCondition();
  }
}
