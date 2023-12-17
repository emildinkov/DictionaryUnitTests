using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruits = new()
        {
            ["apple"] = 5
        };

        string fruitName = "apple";

        // Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new()
        {
            ["apple"] = 5,
        };

        string fruitName = "cherry";

        // Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        // Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new();

        string fruitName = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        // Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruits = null;

        string fruitName = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        // Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruits = new()
        {
            ["banana"] = 5,
            ["apple"] = 3,
            ["cherry"] = 5
        };

        string? fruitName = null;

        // Act
        int result = Fruits.GetFruitQuantity(fruits, fruitName);

        // Assert
        Assert.That(result, Is.Zero);
    }
}
