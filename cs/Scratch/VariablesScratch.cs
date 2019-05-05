namespace Scratch
{
    public class Person {
        string Name;
        int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void changeDetails(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} : {Age}";
        }
    }

}