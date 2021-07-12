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

      IRemoteControl RemoteA = new RemoteControl(_numberOfKey);
      RemoteA.setCommand(0, new LightOnCommand(LivingRoomLight), new LightOffCommand(LivingRoomLight));
      RemoteA.setCommand(1, new TelevisionOnCommand(LivingRoomTelevision), new TelevisionOffCommand(LivingRoomTelevision));
      RemoteA.setCommand(2, new AirConditionerOnCommand(LivingRoomAC), new AirConditionerOffCommand(LivingRoomAC));
      RemoteA.setCommand(3, new FanOnLowCommand(CeilingFan), new FanOffCommand(CeilingFan));
      RemoteA.setCommand(4, new FanOnMediumCommand(CeilingFan), new FanOffCommand(CeilingFan));
      RemoteA.setCommand(5, new FanOnHighCommand(CeilingFan), new FanOffCommand(CeilingFan));

      Console.WriteLine(RemoteA.ViewRemoteCondition());
      // TV test
      RemoteA.onButtonPushed(1);
      RemoteA.offButtonPushed(1);

      // Light test
      RemoteA.onButtonPushed(0);
      RemoteA.offButtonPushed(0);
      RemoteA.undoButtonPushed();
      
      // AC test
      RemoteA.onButtonPushed(2);
      RemoteA.offButtonPushed(2);
      RemoteA.undoButtonPushed();

      // Fan test
      RemoteA.onButtonPushed(3);
      RemoteA.onButtonPushed(4);
      RemoteA.undoButtonPushed();
      RemoteA.onButtonPushed(5);
      RemoteA.offButtonPushed(5);
      RemoteA.undoButtonPushed();
    }
  }
}
