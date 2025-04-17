// See https://aka.ms/new-console-template for more information

using Facade;

var homeTheaterFacade = new HomeTheaterFacade(
    new Amp(),
    new Tuner(),
    new DvdPlayer(),
    new CdPlayer(),
    new Projector(),
    new TheaterLights(),
    new Screen(),
    new PopcornPopper()
);

homeTheaterFacade.WatchMovie("300");
homeTheaterFacade.EndMovie();