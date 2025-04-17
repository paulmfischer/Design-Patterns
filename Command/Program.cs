// See https://aka.ms/new-console-template for more information

using Command;

var simpleRemote = new SimpleRemoteControl();
var light = new Light("Kitchen");
var lightOnCommand = new LightOnCommand(light);

simpleRemote.SetCommand(lightOnCommand);
simpleRemote.ButtonWasPressed();

var remote = new RemoteControl();
var livingRoomLight = new Light("Living Room");
var bedroomLight = new Light("Bedroom");
var stereo = new Stereo();

var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);

var stereoOnCommand = new StereoOnWithCdCommand(stereo);
var stereoOffCommand = new StereoOffCommand(stereo);

remote.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
remote.SetCommand(1, stereoOnCommand, stereoOffCommand);


Console.WriteLine(remote);
Console.WriteLine("\n");

remote.OnButtonWasPressed(0);
remote.OnButtonWasPressed(1);
remote.UndoButtonWasPressed();

remote.OffButtonWasPressed(0);
remote.UndoButtonWasPressed();
remote.OffButtonWasPressed(1);

remote.OnButtonWasPressed(3);
remote.OffButtonWasPressed(3);
