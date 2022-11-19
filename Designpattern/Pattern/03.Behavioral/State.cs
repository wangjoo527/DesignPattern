using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpattern.Pattern._03.Behavioral;
public interface ModeState
{
    public void toggle(ModeSwitch modeSwitch);
}
public class ModeStateLight : ModeState
{
    public void toggle(ModeSwitch modeSwitch)
    {
        Console.WriteLine("Light");
        modeSwitch.setState(new ModeStateDark());
    }
}
public class ModeStateDark : ModeState
{
    public void toggle(ModeSwitch modeSwitch)
    {
        Console.WriteLine("Dark");
        modeSwitch.setState(new ModeStateLight());
    }
}

public class ModeSwitch
{
    private ModeState modeState = new ModeStateLight();
    public void setState(ModeState _modeState)
    {
        modeState = _modeState;
    }
    public void onSwitch()
    {
        modeState.toggle(this);
    }
}



public class StateStart : IStart
{
    public void Main()
    {
        var modeSwitch = new ModeSwitch();
        modeSwitch.onSwitch();
        modeSwitch.onSwitch();
        modeSwitch.onSwitch();
        modeSwitch.onSwitch();
    }
}