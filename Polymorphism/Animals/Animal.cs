using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;

        public Animal(string name, string food)
        {
            this.Name = name;
            this.FavouriteFood = food;
        }

        public string Name
        {
            get => this.name;
            protected set => this.name = value;
        }

        public string FavouriteFood
        {
            get => this.favouriteFood;
            protected set => this.favouriteFood = value;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
