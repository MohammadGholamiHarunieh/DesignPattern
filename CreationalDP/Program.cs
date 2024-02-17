// See https://aka.ms/new-console-template for more information

using CreationalDP.Factory;
using CreationalDP.ProtoType;

Console.WriteLine("Hello, World!");

//****************abstract factory and factory *******************************
var logger = new ConcreteLoggerFactoryB();
logger.Log();

var person = SimpleFactory.CreatePersonWithBrifData("mohammad", "gholami");
Console.WriteLine($"{person.Name} {person.Family}");


var person2 = SimpleFactory2.CreatePersonWithBrifData("ali", "vali");
Console.WriteLine($"{person2.Name} {person2.Family}");



//**************** prototype*************************
var productOriginal = new Product(1, "mohammad");

var productCopy = (Product)productOriginal.Clone();

Console.WriteLine($"original {productOriginal.Id} {productOriginal.Name}");
Console.WriteLine($"copy {productCopy.Id} {productCopy.Name}");

Console.WriteLine($"reference Equality: {object.ReferenceEquals(productOriginal, productCopy)}");

