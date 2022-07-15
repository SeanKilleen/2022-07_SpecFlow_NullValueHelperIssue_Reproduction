using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowTests;

[Binding]
public class TestFeatureSteps
{
    private string _myString;

    [Given("I have a string with a value of (.*)")]
    public void GivenIHaveAWithAValueOf(string theValue)
    {
        _myString = theValue;
    }

    [Then("the string should be null")]
    public void TheStringShouldBeNull()
    {
        _myString.Should().BeNull();
    }

}
