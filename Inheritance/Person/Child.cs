using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        private int age;

        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (this.Age < 15 && this.Age > -1)
                {
                    this.age = Age;
                }
            }
        }


        public Child(string name, int age)
            : base(name, age)
        {
             
        }
    }
}
