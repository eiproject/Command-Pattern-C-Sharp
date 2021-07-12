using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {
  interface IRemoteControl {
    void SetCommand(int slot, ICommand onCommand, ICommand offCommand);
    void OnButtonPushed(int slot);
    void OffButtonPushed(int slot);
    void UndoButtonPushed();
    StringBuilder ViewRemoteCondition();
  }
}
