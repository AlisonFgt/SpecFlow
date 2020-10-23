Feature: Calculator
	A fim de evitar erros
	Como um péssimo matemático
	Eu quero que me digam a soma de dois números

@mytag
Scenario: Somar dois números
	Given o primeiro numero é 50
	And o segundo numero é 70
	When os dois numeros sao adicionados
	Then o resultado deve ser 120