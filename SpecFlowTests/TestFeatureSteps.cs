using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;

namespace SpecFlowTests;

[Binding]
public static class NullValueHooks
{

    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        Service.Instance.ValueRetrievers.Register(new NullValueRetriever("<null>"));
    }
}

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
