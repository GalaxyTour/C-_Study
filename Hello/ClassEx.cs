using System;
using System.Collections.Generic;
using System.IO;

#region Chapter08

namespace MultiInterfaceInheritance
{
    interface IRunnable
    { void Run(); }

    interface IFlyable
    { void Fly(); }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run?!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly!!");
        }
    }

    class MainApp
    {
        static void Main()
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
namespace DerivedInterface
{
/*
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFromattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFromattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);

        }

        public void WriteLog(string format, params Object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class MainApp
    {
        static void Main()
        {
            IFromattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("Test Log");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
*/
}
namespace Interface
{
/*
    interface ILoger
    {
        void WriteLog(string message);
    }

    class ConsoleLoger : ILoger
    {

        public void WriteLog(string message)
        {
            Console.WriteLine("Console Message: [{0}] {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILoger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            Console.WriteLine("Console[File] Message[{0}] {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class ClimateMonitor
    {
        private ILoger logger;
        public ClimateMonitor(ILoger loger)
        {
            this.logger = loger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요.: ");
                string temperture = Console.ReadLine();
                if (temperture == "")
                    break;

                logger.WriteLog("현재 온도: " + temperture);

            }
        }
    }

    class MainApp
    {
        static void Main()
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            ClimateMonitor monitorConsole = new ClimateMonitor(new ConsoleLoger());

            monitor.start();
            monitorConsole.start();
        }
    }
*/
}

#endregion

#region Chapter07
namespace ReadonlyMethod
    {
    /*
        struct ACSetting
        {
            public double currntInCelsius;  // 현재온도(섭씨)
            public double target;           // 희망온도

            public readonly double GetFahrenheit()
            {
                return currntInCelsius * 1.8 + 32;
            }
        }
        class MainApp
        {
            static void Main()
            {
                ACSetting acs;
                acs.currntInCelsius = 25;
                acs.target = 25;

                Console.WriteLine($"{acs.GetFahrenheit()}");
                Console.WriteLine($"{acs.target}");
            }
        }
    */
    }
namespace PosisionalPattern
{
/*
    class MainApp
    {
        private static double GetDiscountRate(object Client)
        {
            return Client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0
            };
        }

        static void Main()
        {
            var yongjun = ("학생", 15);
            var taesung = ("일반", 17);
            var sunghae = ("학생", 25);
            var jaehee = ("일반", 27);
            var unkonwn = ("", "");

            Console.WriteLine($"YongJun{yongjun} : {GetDiscountRate(yongjun)}");
            Console.WriteLine($"TaeSung{taesung} : {GetDiscountRate(taesung)}");
            Console.WriteLine($"SungHae{sunghae} : {GetDiscountRate(sunghae)}");
            Console.WriteLine($"JaeHee {jaehee}  : {GetDiscountRate(jaehee)}");
            Console.WriteLine($"Unkonwn{unkonwn} : {GetDiscountRate(unkonwn)}");

        }
    }
*/
}
namespace Tuple
{
/*
    class MainApp
    {
        static void Main()
        {
            var a = ("정태성", 96);
            Console.WriteLine($"{a.Item1}, {a.Item2}");
            //Console.WriteLine(a);

            var b = (Name: "김용준", Birth: 95);
            Console.WriteLine($"{b.Name}, {b.Birth}");
            //Console.WriteLine($"{b.Item1}, {b.Item2}");

            var (cname, cbirth) = b;
            Console.WriteLine($"{cname}, {cbirth}");

            var (cname2, cbirth2) = ("정태성", 96);
            Console.WriteLine($"{cname2}, {cbirth2}");

            b = a;
            Console.WriteLine($"{b.Name}, {b.Birth}");
        }
    }
*/
}
namespace ReadOnlyStructure
{
/*
    readonly struct RGBColor
    {
        public readonly byte R, G, B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    class MainApp
    {
        static void Main()
        {
            RGBColor rgb = new RGBColor(255, 0, 0);
        }
    }
*/
}
namespace Structure
{
/*
    struct Point3D
    {
        public int X, Y, Z;

        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1;
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine($"p3d1: {p3d1.ToString()}");

            Point3D p3d2 = new Point3D(100, 200, 400);
            Point3D p3d3 = p3d2;    //DeppCopy
            p3d3.Z = 800;

            Console.WriteLine($"p3d2: {p3d2.ToString()}");
            Console.WriteLine($"p3d2: {p3d3.X}, {p3d3.Y}, {p3d3.Z}");
            Console.WriteLine(p3d2);
        }
    }
*/
}
namespace MyExtension
{
    /*
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for(int i = 1; i < exponent; i++)
                result *= myInt;

            return result;
        }
    }

    public static class StringExtension
    {
        public static string Append(this string myString, string appendString)
        {
            return myString + appendString;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 = {3.Square()}");
            Console.WriteLine($"3^4 = {3.Power(4)}");
            Console.WriteLine($"2^10 = {2.Power(10)}");

            string testText = "Kim";
            Console.WriteLine(testText.Append(", YongJun"));
            Console.WriteLine("123".Append("456"));
        }
    }
    */
}
namespace PartialClass
{
    /*
    partial class MyPartialClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    partial class MyPartialClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyPartialClass objPartialClass = new MyPartialClass();

            objPartialClass.Method1();
            objPartialClass.Method2();
            objPartialClass.Method3();
            objPartialClass.Method4();
        }
    }
    */
}
namespace NestedClass
{
    /*
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }

        private class ItemValue
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            {
                return item;
            }

            public string GetValue()
            { 
                return value;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
        }
    }
    */
}
namespace MethodHiding
{
    /*
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {

        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
    */
}
namespace IronManOverriding
{
    /*
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            IronMan ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating Warmuchine");
            WarMachine warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
    */
}
namespace TypeCasting
{
    /*
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog :Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat :Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;

            if(cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("Cat2 is not a cat");

        }
    }
    */
}
namespace Inheritance
{
    /*
    class Base
    {
        protected string Name;

        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            Console.WriteLine($"{this.Name}.~ Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethode()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Dervied()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Dervied()");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerviedMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
    */
}
namespace AccessModifier
{
    /*
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperture range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine("[Turn on water]");
            Console.WriteLine($"Temperture: {temperature}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    */
}
namespace ThisConstructor
{
    /*
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 1234;
            Console.WriteLine("Call MyClass()");
        }

        public MyClass(int b) :this()
        {
            this.b = b;
            Console.WriteLine($"Call MyClass({b})");
        }

        public MyClass(int b, int c) :this(b)
        {
            this.c = c;
            Console.WriteLine($"Call MyClass({b}, {c})");
        }

        public void PrintField()
        {
            Console.WriteLine($"a:{this.a}, b:{this.b}, c:{this.c}");
        }
    }
    class MainApp
    {
        static void Main(string[] afgs)
        {
            MyClass a = new MyClass();
            a.PrintField();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintField();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintField();
        }
    }
    */
}
namespace This
{
    /*
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPostion()
        {
            return this.Position;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooch = new Employee();
            pooch.SetName("Pooch");
            pooch.SetPosition("Waiter");
            Console.WriteLine($"Name: {pooch.GetName()} / Position: {pooch.GetPostion()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"Name: {tigger.GetName()} / Position: {tigger.GetPostion()}");
        }
    }
    */
}
namespace ClassCopy
{
    /*
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();

            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
    */
}
namespace StaticClass
{
    #region StaticClass
    /*
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class MainApp
    {
        static void Main()
        {
            Console.WriteLine($"Global Count: {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global Count: {Global.Count}");
        }
    }
    */
    #endregion
}
namespace BasicClass
{

    #region Class_1
    /*
    class NccWkpers
    {
        public string ID;
        public string Name;
        public string Dept;

        public void GetWkpersInfo()
        {
            Console.WriteLine("직원정보");
            Console.WriteLine($"WKPERS_ID: {ID}, Name: {Name}, Dept: {Dept}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NccWkpers wkpers_1 = new NccWkpers
            {
                ID = "91560",
                Name = "김용준",
                Dept = "051_W"
            };

            wkpers_1.GetWkpersInfo();

            NccWkpers wkpers_2 = new NccWkpers();

            wkpers_2.ID = "90973";
            wkpers_2.Name = "최양효";
            wkpers_2.Dept = "APIT";

            wkpers_2.GetWkpersInfo();
        }
    }
    */
    #endregion
}
#endregion