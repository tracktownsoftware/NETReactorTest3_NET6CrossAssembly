using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("My.Interface.Extended.Implementor")]
[assembly: InternalsVisibleTo("ConsoleTestApp")]

namespace My.Interface.Extended
{
    internal interface IHelloWorldExtended: IHelloWorld
    {
        string HelloWorld2
        {
            get;
        }
    }
}