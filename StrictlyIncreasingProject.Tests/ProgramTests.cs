using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program = StrictlyIncreasingProject.Program;

namespace TestProject1;

public class ProgramTests
{
    [Test]
    // public void ThingWeAreTesting_WhenShouldHappen_ExpectedResult()
    public void IsStrictlyIncreasing_WhenPassedIncreasingArray_ShouldBeTrue()
    {
        // Setup
        var testArray = new int[] { 1, 2, 3, 4, 5, 6 };
        var sut = new Program();
        
        // Act
        var result = sut.IsStrictlyIncreasing(testArray);

        // Assert
        result.Should().Be(true);
    }
    
    [Test]
    public void IsStrictlyIncreasing_WhenPassedGarbage_ShouldBeFalse()
    {
        // Setup
        var testArray = new int[] { 1, 1, 1, 1 };
        var sut = new Program();
        
        // Act
        var result = sut.IsStrictlyIncreasing(testArray);

        // Assert
        result.Should().Be(false);
    }
    
    [Test]
    public void IsStrictlyIncreasing_WhenPassedOneSkip_ShouldBeTrue()
    {
        // Setup
        var testArray = new int[] { 1, 3, 4, 1, 5, 6 };
        var sut = new Program();
        
        // Act
        var result = sut.IsStrictlyIncreasing(testArray);

        // Assert
        result.Should().Be(true);
    }
 

    [Test]
    public void IsStrictlyIncreasing_WhenPassedTwoSkips_ShouldBeFalse()
    {
        // Setup
        var testArray = new int[] { 1, 3, 4, 1, 5, 1, 6 };
        var sut = new Program();

        // Act
        var result = sut.IsStrictlyIncreasing(testArray);

        // Assert
        result.Should().Be(false);
    }
    
    [Test]
    public void IsStrictlyIncreasing_FirstTwoElementsNotIncreasing_ShouldBeFalse()
    {
        // Setup
        var testArray = new int[] { 5, 5, 1, 2, 3 };
        var sut = new Program();
        
        // Act
        var result = sut.IsStrictlyIncreasing(testArray);

        // Assert
        result.Should().Be(false);
    }
}