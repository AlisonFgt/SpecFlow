﻿using BDDSpecFlow.Example;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDSpecFlow.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private int result;

        private Calculator calculator = new Calculator();        

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("o primeiro numero é (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given("o segundo numero é (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.SecondNumber = number;
        }

        [When("a operacao sera (.*)")]
        public void WhenTheTwoNumbersAreAdded(string operacao)
        {
            if (operacao.Equals("soma"))
                result = calculator.Sum();
            else if (operacao.Equals("subtracao"))
                result = calculator.Subtraction();
        }

        [Then("o resultado deve ser (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
