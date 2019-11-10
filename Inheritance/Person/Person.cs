using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.age >= 0 )
                {
                    this.age = Age;
                }
            }
        }



        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.age));

            return sb.ToString();
        }

    }
}
