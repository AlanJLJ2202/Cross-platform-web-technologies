using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Tests;

public class PersonShould
{
    [Fact]
    public void Weight_SetWeightValue_ReturnSameValue()
    {
        //arrange
        float expected = 70;
        var sut = new Person();
        
        //act
        sut.Weight = expected;
        var result = sut.Weight;
        
        //assert
        Assert.Equal(expected, result);
    }

}