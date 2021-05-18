# The brief

[kata from codewars](https://www.codewars.com/kata/59f6a855bee845d3cd000046)

You have a simple Cafeteria.

You can create 3 coffee recipes:
* Black = Black coffee
* Cubano = Cubano coffee + Brown sugar
* Americano = Americano coffee + Milk with 0.5% fat

And you can add a lot of extra sugar and extra milk in any coffee, e.g.:
* Black + Milk with 3.2% fat + Brown sugar
* Cubano + Brown sugar + Brown sugar + Regular sugar
* Americano + Milk with 3.2% fat + Milk with 0% fat + Regular sugar

You need to create a Coffee by implementing a CoffeeBuilder struct/class like in the Builder design pattern.

# to run

requires dotnet sdk

```
cd cafeteria.tests
dotnet build
dotnet test
```