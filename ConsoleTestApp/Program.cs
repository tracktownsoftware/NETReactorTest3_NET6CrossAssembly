// See https://aka.ms/new-console-template for more information

Console.WriteLine("Running tests...");
var myImpl = new My.Interface.Extended.Implementor.MyInterfaceExtendedImplementor();
Console.WriteLine(((My.Interface.IHelloWorld)(myImpl)).HelloWorld);
Console.WriteLine(((My.Interface.Extended.IHelloWorldExtended)(myImpl)).HelloWorld2);
Console.WriteLine("Tests completed");
Console.ReadKey();