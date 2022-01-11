using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("ConsoleTestApp")]

namespace My.Interface.Extended.Implementor
{
    internal class MyInterfaceExtendedImplementor : IHelloWorldExtended
    {
        string IHelloWorld.HelloWorld => "Success: IHelloWorld.HelloWorld";

        string IHelloWorldExtended.HelloWorld2 => "Success: IHelloWorldExtended.HelloWorld2";

    }

}
