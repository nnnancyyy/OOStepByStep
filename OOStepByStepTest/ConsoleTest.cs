using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOPractice;
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Should_return_message_for_student()
        {
            //given
            Student student = new Student("Tom", 18, "student");
            //when
            string message = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", message);
        }

        [Fact]
        public void Should_return_message_for_teacher()
        {
            //given
            Teacher teacher = new Teacher("Tom", 18, "teacher");
            //when
            string message = teacher.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a teacher.", message);
        }
    }
}
