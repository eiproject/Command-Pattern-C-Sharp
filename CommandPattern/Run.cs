using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models;

namespace CommandPattern {
  class Run {
    private int _numberOfKey = 5;
    internal void RunRemoteTest1() {
      Light LivingRoomLight = new Light();
      Television LivingRoomTelevision = new Television();
      AirConditioner LivingRoomAC = new AirConditioner();

      IRemoteControl RemoteA = new RemoteControl(_numberOfKey);
      RemoteA.setCommand(0, new LightOnCommand(LivingRoomLight), new LightOffCommand(LivingRoomLight));
      RemoteA.setCommand(1, new TelevisionOnCommand(LivingRoomTelevision), new TelevisionOffCommand(LivingRoomTelevision));
      RemoteA.setCommand(2, new AirConditionerOnCommand(LivingRoomAC), new AirConditionerOffCommand(LivingRoomAC));

      Console.WriteLine(RemoteA.ViewRemoteCondition());

      RemoteA.onButtonPushed(1);
      RemoteA.offButtonPushed(1);
    }
  }
}
