using PRACTICA_3_ISR_CORE.Entities;
using PRACTICA_3_ISR_CORE.Enums;
using PRACTICA_3_ISR_CORE.Services;

namespace PRACTICA_3_ISR_TEST;

public class SueldoServiceShould
{
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan0_01AndLowerThan7735ReturnsTypeNivel1()
    {
        //arrange
        var expectedType = 95.99981f;
        var person = new PersonISR {Sueldo = 5000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan7735_01AndLowerThan65651_07ReturnsTypeNivel2()
    {
        //arrange
        var expectedType = 2853.4697f;
        var person = new PersonISR {Sueldo = 50000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan65651_08AndLowerThan115375_90ReturnsTypeNivel3()
    {
        //arrange
        var expectedType = 7592.3027f;
        var person = new PersonISR {Sueldo = 100000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan115375_91AndLowerThan134119_41ReturnsTypeNivel4()
    {
        //arrange
        var expectedType = 10005.055f;
        var person = new PersonISR {Sueldo = 120000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan134119_42AndLowerThan160577_65ReturnsTypeNivel5()
    {
        //arrange
        var expectedType = 15109.96f;
        var person = new PersonISR {Sueldo = 150000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan160577_66AndLowerThan323862_00ReturnsTypeNivel6()
    {
        //arrange
        var expectedType = 46786.086f;
        var person = new PersonISR {Sueldo = 300000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan323862_01AndLowerThan510451_00ReturnsTypeNivel7()
    {
        //arrange
        var expectedType = 93310.67f;
        var person = new PersonISR {Sueldo = 500000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan510451_01AndLowerThan974535_03ReturnsTypeNivel8()
    {
        //arrange
        var expectedType = 212633.44f;
        var person = new PersonISR {Sueldo = 900000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan974535_04AndLowerThan1299380_04ReturnsTypeNivel9()
    {
        //arrange
        var expectedType = 243397.38f;
        var person = new PersonISR {Sueldo = 1000000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan1299380_05AndLowerThan3898140_12ReturnsTypeNivel10()
    {
        //arrange
        var expectedType = 577155.1f;
        var person = new PersonISR {Sueldo = 2000000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
    [Fact]
    public void ProcessISR_WhenIndexHigherOrEqualThan3898140_13ReturnsTypeNivel11()
    {
        //arrange
        var expectedType = 1258173.6f;
        var person = new PersonISR {Sueldo = 4000000};
        var sut = new SueldoService();
        
        //act
        var result = sut.ProcessISR(person);
        
        
        //Assert
        Assert.Equal(expectedType, result.ISR);
    }
    
}