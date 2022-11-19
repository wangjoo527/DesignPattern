using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpattern.Pattern._01.Create;
public class Singleton
{
    private static Singleton staticSingleton;
    public static Singleton Instance()
    {
        if(staticSingleton is null)
        {
            staticSingleton = new Singleton();
        } 
        return staticSingleton;
    }
}
public class SingletonStart : IStart
{ 
    public void Main()
    {
        var objectA = Singleton.Instance();
        var objectB = Singleton.Instance();
        var objectC = Singleton.Instance();
    }
}
