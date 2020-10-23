Feature: Operações da Calculadora
	A fim de evitar erros
	Como um péssimo matemático
	Eu quero que me digam o resultado da operação de dois números

Scenario: Operar dois números
	Given o primeiro numero é <valor1>
	And o segundo numero é <valor2>
	When a operacao sera <operacao>
	Then o resultado deve ser <total>

	Examples: 
		| valor1 | valor2 | operacao  | total |
		| 50     | 70     | soma      | 120   |
		| 20     | 10     | subtracao | 10    |
		| 80     | 20     | soma      | 100   |
		| 10     | 5      | subtracao | 5     |