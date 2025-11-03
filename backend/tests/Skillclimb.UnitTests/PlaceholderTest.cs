using Shouldly;

namespace Skillclimb.UnitTests;

public class PlaceholderTest
{
    [Fact]
    public void Test()
    {
        var testValue = 1;

        testValue.ShouldBe(1);
    }
}
