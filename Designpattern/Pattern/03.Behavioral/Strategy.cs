using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpattern.Pattern._03.Behavioral;
interface FlyBehavior
{
    public void Fly();
}

public class Duck : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("오리~~");
    }
}
public class Eagle : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("독수리");
    }
}
public class StrategyStart : IStart
{
    public void Main()
    {
        new Eagle().Fly();
        new Duck().Fly();
    }
}