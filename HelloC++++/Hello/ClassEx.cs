using System;

namespace ClassCopy
{
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
