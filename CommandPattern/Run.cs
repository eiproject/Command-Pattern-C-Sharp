using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models;

namespace CommandPattern {
  class Run {
    private int _numberOfKey = 7;
    internal void RemoteLoader() {
      Light LivingRoomLight = new Light("Living Room");
      Television LivingRoomTelevision = new Television("Living Room");
      AirConditioner LivingRoomAC = new AirConditioner("Living Room");
      Fan CeilingFan = new Fan("Ceiling");

      ICommand[] ComingHomeCommand = {
        new LightOnCommand(LivingRoomLight),
        new AirConditionerOnCommand(LivingRoomAC),
        new FanOnMediumCommand(CeilingFan)
      };
      ICommand[] LeavingHomeCommand = {
        new LightOffCommand(LivingRoomLight),
        new AirConditionerOffCommand(LivingRoomAC),
        new FanOffCommand(CeilingFan)
      };
      MacroCommand ComingHome = new MacroCommand(ComingHomeCommand);
      MacroCommand LeavingHome = new MacroCommand(LeavingHomeCommand);

      IRemoteControl RemoteA = new RemoteControl(_numberOfKey);
      RemoteA.SetCommand(0, new LightOnCommand(LivingRoomLight), new LightOffCommand(LivingRoomLight));
      RemoteA.SetCommand(1, new TelevisionOnCommand(LivingRoomTelevision), new TelevisionOffCommand(LivingRoomTelevision));
      RemoteA.SetCommand(2, new AirConditionerOnCommand(LivingRoomAC), new AirConditionerOffCommand(LivingRoomAC));
      RemoteA.SetCommand(3, new FanOnLowCommand(CeilingFan), new FanOffCommand(CeilingFan));
      RemoteA.SetCommand(4, new FanOnMediumCommand(CeilingFan), new FanOffCommand(CeilingFan));
      RemoteA.SetCommand(5, new FanOnHighCommand(CeilingFan), new FanOffCommand(CeilingFan));
      RemoteA.SetCommand(6, ComingHome, LeavingHome);

      Console.WriteLine(RemoteA.ViewRemoteCondition());
      // TV test
      RemoteA.OnButtonPushed(1);
      RemoteA.OffButtonPushed(1);

      // Light test
      RemoteA.OnButtonPushed(0);
      RemoteA.OffButtonPushed(0);
      RemoteA.UndoButtonPushed();

      // AC test
      RemoteA.OnButtonPushed(2);
      RemoteA.OffButtonPushed(2);
      RemoteA.UndoButtonPushed();

      // Fan test
      RemoteA.OnButtonPushed(3);
      RemoteA.OnButtonPushed(4);
      RemoteA.UndoButtonPushed();
      RemoteA.OnButtonPushed(5);
      RemoteA.OffButtonPushed(5);
      RemoteA.UndoButtonPushed();

      // AC test
      RemoteA.OnButtonPushed(6);
      RemoteA.OffButtonPushed(6);
      RemoteA.UndoButtonPushed();

    }
  }
}
