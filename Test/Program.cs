using System;
using System.Collections.Generic;
using System.Linq;
using Test.AbstractFactoryPattern;
using Test.AddapterPattern;
using Test.CofeeDecoratorPattern;
using Test.FacadePattern;
using Test.FactoryMethodPattern;
using Test.ProxyPattern;
using Test.WheatherObservablePattern;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////// Strategy Pattern
            //IHornStrategy audiHorn = new AudiHornStrategy();
            //IHornStrategy bmwHorn = new BMWHornStrategy();

            //Car car = new Car(audiHorn);
            //Car carb = new Car(bmwHorn);

            //Console.WriteLine(car.PressHorn());
            //Console.WriteLine(carb.PressHorn());
            //////////////////////////

            ////////////////////////// Observer Pattern
            //Console.WriteLine("Please enter the temperature?");
            //string temperature = Console.ReadLine();
            //IObservable wheaterStation = new WheaterStation();

            //IObserver mobilePhone = new MobilePhone();
            //wheaterStation.Add(mobilePhone);

            //IObserver tablet = new Tablet();
            //wheaterStation.Add(tablet);

            //wheaterStation.Notify(temperature);
            //////////////////////////

            ////////////////////////// Decorator Pattern

            //Beverage cofee = new Expresso(new CaramelDecorator());
            //Beverage tea = new Tea(new MilkDecorator());

            //Console.WriteLine("Cofee with caramel: " + cofee.Cost());
            //Console.WriteLine("Tea with milk: " + tea.Cost());
            //////////////////////////

            ////////////////////////// FactoryMethodPattern
            //ShapeFactory shapeFactory = new ShapeFactory();

            //var shape = shapeFactory.GetShape(ShapeTypes.Circle);
            //Console.WriteLine("You drew a " + shape.Draw());

            //var shape1 = shapeFactory.GetShape(ShapeTypes.Rectangle);
            //Console.WriteLine("You drew a " + shape1.Draw());

            //var shape2 = shapeFactory.GetShape(ShapeTypes.Square);
            //Console.WriteLine("You drew a " + shape2.Draw());
            //////////////////////////

            ////////////////////////// AbstractFactoryPattern
            //IMobilePhone nokiaMobilePhone = new Nokia();
            //MobileAbstractFactory nokiaClient = new MobileAbstractFactory(nokiaMobilePhone);

            //Console.WriteLine("********* NOKIA **********");
            //Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            //Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            //IMobilePhone samsungMobilePhone = new Samsung();
            //MobileAbstractFactory samsungClient = new MobileAbstractFactory(samsungMobilePhone);

            //Console.WriteLine("******* SAMSUNG **********");
            //Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            //Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());
            //////////////////////////

            ////////////////////////// Adapter Pattern
            //IAdapter adapter = null;

            //Let emulate the decision where the choice of using the underlying system is made
            //Console.WriteLine("Enter which library you wanna use to do operation {1,2}");
            //int x = Console.Read();

            //if (x == '1')
            //{
            //    //Let us choose to use Library one to do something
            //    adapter = new AdapterOne();
            //}
            //else if (x == '2')
            //{
            //    //Let us choose to use Library two to do something
            //    adapter = new AdapterTwo();
            //}

            ////Just do the operation now
            //adapter.Do();
            //////////////////////////

            ///////////////////////// Facade
            //MortgageFacade mortgage = new MortgageFacade();

            //// Evaluate mortgage eligibility for customer
            //Customer customer = new Customer("Ann McKinsey");
            //bool eligible = mortgage.IsEligible(customer, 125000);

            //Console.WriteLine("\n" + customer.Name +
            //    " has been " + (eligible ? "Approved" : "Rejected"));
            ///////////////////////

            ///////////////////////// ProxyPattern
            MathProxy proxy = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
            ///////////////////////

            Console.ReadKey();
        }
    }
}
