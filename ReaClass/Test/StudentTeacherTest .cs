using ReaClass.Concrete;

namespace ReaClass.Test
{
    public class StudentTeacherTest
    {
        public void Test()
        {
            var person = new Person();
            person.Greet();

            var student = new Student();
            student.SetAge(27);
            student.Greet();
            student.ShowAge();
            student.Study();

            var teacher = new Teacher();
            teacher.SetAge(27);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
