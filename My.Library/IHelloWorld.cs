using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("My.Interface.Extended")]
[assembly: InternalsVisibleTo("My.Interface.Extended.Implementor")]
[assembly: InternalsVisibleTo("ConsoleTestApp")]

namespace My.Interface
{
    internal interface IHelloWorld
    {
        string HelloWorld
        {
            get;
        }
    }
}