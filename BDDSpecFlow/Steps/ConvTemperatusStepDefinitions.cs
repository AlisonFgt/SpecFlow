using BDDSpecFlow.Example;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDSpecFlow.Steps
{
    [Binding]
    public sealed class ConvTemperatusStepDefinitions
    {
        private double _temperaturaFahrenheit;
        private double _temperaturaCelsius;
        private double _temperaturaKelvin;

        [Given("que o valor da temperatura é de (.*) graus Fahrenheit")]
        public void PreencherTemperaturaFahrenheit(double valorFahrenheit)
        {
            _temperaturaFahrenheit = valorFahrenheit;
        }

        [When("eu solicitar a conversão desta temperatura")]
        public void ProcessarConversao()
        {
            var objTemperatura = new Temperatura(_temperaturaFahrenheit);
            _temperaturaCelsius = objTemperatura.Celsius;
            _temperaturaKelvin = objTemperatura.Kelvin;
        }

        [Then("o resultado da conversão para Celsius será de (.*) graus")]
        public void ValidarResultadoCelsius(double valorCelsius)
        {
            Assert.AreEqual(valorCelsius, _temperaturaCelsius);
        }

        [Then("o resultado da conversão para Kelvin será de (.*) graus")]
        public void ValidarResultadoKelvin(double valorKelvin)
        {
            Assert.AreEqual(valorKelvin, _temperaturaKelvin);
        }
    }
}
