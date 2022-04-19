using System;

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
