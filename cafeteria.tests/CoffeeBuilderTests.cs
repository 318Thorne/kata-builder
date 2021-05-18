using System.Linq;
using NUnit.Framework;

namespace cafeteria.tests
{
    [TestFixture]
    public class CoffeeBuilderTests
    {
        private readonly ICoffeeBuilder coffeeBuilder;

        public CoffeeBuilderTests()
        {
            coffeeBuilder = new CoffeeBuilder();
        }

        [SetUp]
        public void Setup()
        {
            coffeeBuilder.Reset();
        }

        [Test]
        public void CorrectlyBuildsBlackCoffee()
        {
            var coffee = coffeeBuilder.MakeBlack().Serve();
            Assert.AreEqual("Black", coffee.Sort);
            Assert.IsEmpty(coffee.Milk);
            Assert.IsEmpty(coffee.Sugars);
        }

        [Test]
        public void CorrectlyBuildsAmericano()
        {
            var coffee = coffeeBuilder.MakeAmericano().Serve();
            Assert.AreEqual("Americano", coffee.Sort);
            Assert.IsEmpty(coffee.Sugars);
            Assert.AreEqual(1, coffee.Milk.Count);
            Assert.AreEqual(0.5, coffee.Milk.First().Fat);
        }

        [Test]
        public void CorrectlyBuildsCubano()
        {
            var coffee = coffeeBuilder.MakeCubano().Serve();
            Assert.AreEqual("Cubano", coffee.Sort);
            Assert.IsEmpty(coffee.Milk);
            Assert.AreEqual(1, coffee.Sugars.Count);
            Assert.AreEqual("Brown", coffee.Sugars.First().Sort);
        }

        [Test]
        public void ShouldAddMilkAndSugar()
        {
            var coffee = coffeeBuilder.MakeBlack()
                        .AddMilk(1.5)
                        .AddSugar("White")
                        .Serve();
            Assert.AreEqual(1, coffee.Sugars.Count);
            Assert.AreEqual("White", coffee.Sugars.First().Sort);
            Assert.AreEqual(1, coffee.Milk.Count);
            Assert.AreEqual(1.5, coffee.Milk.First().Fat);
        }
    }
}