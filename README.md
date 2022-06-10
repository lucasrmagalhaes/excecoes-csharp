**C#: entendendo exceções**

**Catch (Exception)** captura todos os tipos de exceção e deve ser definido por último.

**StackOverflowException:** Lançada quando a pilha de execução acaba tendo muitas chamadas de método pendentes, normalmente indica uma recursão muito profunda ou infinita;

**TypeInitializationException:** Ocorre quando um construtor estático lança uma exceção e não há nenhuma cláusula catch compatível para capturá-la;

**OverflowException:** Lançada quando uma operação aritmética em um contexto checked estoura;

A ordem das cláusulas importa, já que são examinadas em ordem;

A exceções mais específicas devem ser capturadas antes das menos específicas; e

Terá um erro de compilação se ordenar os blocos catch de forma que um bloco posterior nunca possa ser alcançado.