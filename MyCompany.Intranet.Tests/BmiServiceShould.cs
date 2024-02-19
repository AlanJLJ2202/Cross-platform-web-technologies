using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Services;
using MyCompany.Intranet.Core.Enums;

namespace MyCompany.Intranet.Tests;

public class BmiServiceShould
{
    [Fact]
    public void ProcessBmi_WhenIndexLessThan18_5ReturnsTypeLow()
    {
        //arrange
        var expectedType = BmiType.Low;
        var person = new Person {Height = 1.70f, Weight = 50f};
        var sut = new BmiService();
        
        //act
        var result = sut.ProcessBmi(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.BmiType);
    }
    
    
    [Fact]
    public void ProcessBmi_WhenIndexHigherOrEqualThan_18_5AndLessThan24_9ReturnsTypeNormal()
    {
        //arrange
        var expectedType = BmiType.Normal;
        var person = new Person {Height = 1.70f, Weight = 60f};
        var sut = new BmiService();
        
        //act
        var result = sut.ProcessBmi(person);
        
        //Assert
        Assert.Equal(expectedType, result.BmiType);
    }
    
    
    [Fact]
    public void ProcessBmi_WhenIndexHigherOrEqualThan_24_9AndLessThan29_9ReturnsTypeOverWeight()
    {
        //arrange
        var expectedType = BmiType.Overweigth;
        var person = new Person {Height = 1.70f, Weight = 75f};
        var sut = new BmiService();
        
        //act
        var result = sut.ProcessBmi(person);
        
        //Assert
        Assert.Equal(expectedType, result.BmiType);
    }
    
    
    [Fact]
    public void ProcessBmi_WhenIndexHigherOrEqualTo_29_9ReturnsTypeObesity()
    {
        //arrange
        var expectedType = BmiType.Obesity;
        var person = new Person {Height = 1.70f, Weight = 100f};
        var sut = new BmiService();
        
        //act
        var result = sut.ProcessBmi(person);
        
        //Assert
        Assert.Equal(expectedType, result.BmiType);
    }
    
}