// See https://aka.ms/new-console-template for more information
using BehaviouralDP.ChainofResponsibility;
using BehaviouralDP.Command;
using BehaviouralDP.Iterator;
using BehaviouralDP.Mediator;
using BehaviouralDP.Memento;
using BehaviouralDP.Observer;
using BehaviouralDP.State;
using BehaviouralDP.Strategy;
using BehaviouralDP.TemplateMethod;
using BehaviouralDP.Visitor;

Console.WriteLine("Hello, World!");


//************ chain of responsibility ******************


//var boss = new Boss();
//var deputy = new Deputy();
//var employee=new Employee();

//boss.SetNextSigner(deputy);
//deputy.SetNextSigner(employee);

//boss.Sign();

//********************************************************

//*********** Command ******************

//var order1 = new BuyOrder(100);
//var order2=new SellOrder(100);

//var orderHandler1=new CommandHandler(order1);
//orderHandler1.Handle();

//var orderHandler2=new CommandHandler(order2);
//orderHandler2.Handle();

//*************************************

//************ Iterator *****************

//ConcreteAggregate<string> aggregate = new ConcreteAggregate<string>();
//aggregate.AddItem("Item 1");
//aggregate.AddItem("Item 2");
//aggregate.AddItem("Item 3");

//var iterator = aggregate.GetIterator();

//Console.WriteLine(iterator.First());

//while (iterator.HasNext())
//{
//    Console.WriteLine(iterator.Next());
//}
//*************************************

//****************** mediator ******************

//// Creating mediator
//ConcreteMediator mediator = new ConcreteMediator();

//// Creating colleagues and setting the mediator
//var colleague1 = new ConcreteColleague1(mediator);
//var colleague2 = new ConcreteColleague2(mediator);

//mediator.SetConcreteColleague1(colleague1);
//mediator.SetConcreteColleague2(colleague2);

//// Colleague communication through the mediator
//colleague1.Send("Hello from Colleague1!");
//colleague2.Send("Hi from Colleague2!");

//*******************************************

//****************** memento ******************

//Originator originator = new Originator();
//originator.State = "State 1";

//Caretaker caretaker = new Caretaker();
//var memento = originator.CreteSnapshot();

//caretaker.Memento = memento;

//originator.State = "State 2";

//originator.Undo(caretaker.Memento);

//*******************************************

//****************** observer ******************

//var obs1 = new ConcreteObserver1();
//obs1.SetState("'obs1 state 1'");

//var obs2=new ConcreteObserver2();
//obs2.SetState("'obs2 state 1'");

//var subj = new ConcreteSubject();
//subj.Attach(obs1);
//subj.Attach(obs2);

//subj.NotifyObservers("'subj new state'");

//*******************************************

//****************** state ******************

//var paint = new Paint(new BluePen());

//paint.DrawLine();

//paint.SetColorPen(new RedPen());

//paint.DrawLine();


//*******************************************

//****************** strategy ******************

//var orderSetter1=new Trade(new EMAStrategy());

//orderSetter1.OpenOrder();

//var orderSetter2=new Trade(new RSIStrategy());

//orderSetter2.OpenOrder();


//*******************************************

//****************** template ******************

//var firstMethod = new FirstMethod();
//firstMethod.Do();

//Console.WriteLine("****************");

//var secondMethod=new SecondMethod();
//secondMethod.Do();

//*******************************************

//****************** visitor ******************

var structure = new ObjectStructure();

var el1 = new Element1();
var el2 = new Element2();
structure.AddElement(el1);
structure.AddElement(el2);

var visitor1 = new Visitor1();

structure.Visit(visitor1);

//*******************************************