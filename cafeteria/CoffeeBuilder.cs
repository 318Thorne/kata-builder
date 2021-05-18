using System;

namespace cafeteria
{
    public interface ICoffeeBuilder
    {
        Coffee Serve();
        ICoffeeBuilder MakeAmericano();
        ICoffeeBuilder MakeCubano();
        ICoffeeBuilder MakeBlack();
        ICoffeeBuilder AddMilk(double fat);
        ICoffeeBuilder AddSugar(string sort);
        void Reset();
    }

    public class CoffeeBuilder : ICoffeeBuilder
    {
        private Coffee coffee;

        public CoffeeBuilder()
        {
            Reset();
        }

        public ICoffeeBuilder AddMilk(double fat)
        {
            coffee.Milk.Add(new Milk(fat));
            return this;
        }

        public ICoffeeBuilder AddSugar(string sort)
        {
            coffee.Sugars.Add(new Sugar(sort));
            return this;
        }

        public ICoffeeBuilder MakeAmericano()
        {
            Reset();
            coffee.Sort = "Americano";
            return AddMilk(0.5);
        }

        public ICoffeeBuilder MakeBlack()
        {
            Reset();
            coffee.Sort = "Black";
            return this;
        }

        public ICoffeeBuilder MakeCubano()
        {
            Reset();
            coffee.Sort = "Cubano";
            return AddSugar("Brown");
        }

        public Coffee Serve()
        {
            return coffee;
        }

        public void Reset()
        {
            coffee = new Coffee();
        }
    }
}
