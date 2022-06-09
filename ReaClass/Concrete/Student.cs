using System;

namespace ReaClass.Concrete
{
    public class Student : Person
    {
        public void Study() => Console.WriteLine("I am studying.");

        public void ShowAge() => Console.WriteLine($"My age is: {base.age} years old.");
    }
}
