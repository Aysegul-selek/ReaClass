using System;

namespace ReaClass.Concrete
{
    public class Person
    {
        protected int age;
        public void Greet() => Console.WriteLine("Hello!");

        public void SetAge(int age) => this.age = age;
    }
}
