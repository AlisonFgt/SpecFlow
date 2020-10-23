Feature: Conversão de temperaturas em Fahrenheit

Scenario: SimulacaoTemperatura
	Given que o valor da temperatura é de <fahrenheit> graus Fahrenheit
	When eu solicitar a conversão desta teperatura
	Then o resultado da conversão para Celsius será de <celsius> graus
	And o resultado da conversão para Kelvin será de <resultadoEsperado> graus

	Examples: 
		| fahrenheit | celsius | resultadoEsperado |
		| 32         | 0       | 273.15            |
		| 86         | 30      | 303.15            |
		| 47         | 8.33    | 281.48            |
		| 90.5       | 32.5    | 305.65            |
		| 120.18     | 48.99   | 322.14            |
		| 212        | 100     | 373.15            |