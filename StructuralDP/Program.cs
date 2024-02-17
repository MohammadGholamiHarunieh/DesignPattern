// See https://aka.ms/new-console-template for more information
using StructuralDP.Adapter;
using StructuralDP.Bridge;
using StructuralDP.Decorator;
using StructuralDP.Facade;
using StructuralDP.FlyWeight;

Console.WriteLine("Hello, World!");
//******************** composite *************************

//var file1 = new CreationalDP.Composite.File(10);

//var file2=new CreationalDP.Composite.File(20);

//var file3=new CreationalDP.Composite.File(30);

//var folder1=new Folder(0);

//var folder2=new Folder(0);

//folder1.Add(file1);
//folder1.Add(file2);

//Console.WriteLine($"Folder 1 size alone = {folder1.CalCulateSize()}");
//folder2.Add(file3);

//Console.WriteLine($"Folder 2 size  = {folder2.CalCulateSize()}");


//folder1.Add(folder2);
//Console.WriteLine($"Folder 1+2 size  = {folder1.CalCulateSize()}");

//*****************************

//*************** bridge ********************

var drawer1 = new ShapeDriver1(new Circle());

drawer1.Draw();
drawer1.Clean();

var drawer2 = new ShapeDriver2(new Square());

drawer2.Draw();
drawer2.Clean();

//********************************************
//************* adapter ********************

//var adapter = new Adapter(new Adaptee());

//adapter.CustomerWants();

//*******************************************

//************** Decorator ******************


//var developer = new IWantToSendPr();

//var cto = new IShouldCheckItBefore(developer);

//cto.Do();

//**************************************************

//*********** Facade **********************

//var fullRobot = new FullRobot();

//var buyerRobot=new IJustShop();

//IWantToToDoShoping.So();

//******************************

//********* flywight ************

//var letterCreator=new AlphabetFactory();

//var myLetter = letterCreator.GetAlphabet("m").Print() + 
//               letterCreator.GetAlphabet("o").Print() +
//               letterCreator.GetAlphabet("h").Print() +
//               letterCreator.GetAlphabet("a").Print() +
//               letterCreator.GetAlphabet("m").Print() + 
//               letterCreator.GetAlphabet("m").Print() + 
//               letterCreator.GetAlphabet("a").Print() + 
//               letterCreator.GetAlphabet("d").Print();

//Console.WriteLine($"My Name IS '{myLetter}'");

//************************


