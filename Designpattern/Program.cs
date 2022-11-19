using Designpattern;
using Designpattern.Pattern._01.Create;
using Designpattern.Pattern._03.Behavioral;

IStart start;

#region Create
//01.Singleton
start = new SingletonStart();
start = new StrategyStart();
start = new StateStart();   
#endregion


start.Main();

