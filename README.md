Verificador de Expressões Balanceadas
Este programa em C# implementa um verificador de expressões matemáticas para garantir que os parênteses, colchetes e chaves estejam balanceados corretamente.

Funcionalidades
VerificarExpressao: Método público que recebe uma expressão como entrada e retorna true se os parênteses, colchetes e chaves estiverem balanceados corretamente. Caso contrário, retorna false.
Detalhes de Implementação
O programa utiliza uma pilha para rastrear as aberturas de parênteses, colchetes e chaves. Durante a iteração pelos caracteres da expressão, o programa verifica se um caractere é uma abertura ou fechamento. Se for uma abertura, o caractere é empilhado. Se for um fechamento, o programa verifica se a pilha não está vazia e se a abertura correspondente está no topo da pilha. Se todas as verificações forem bem-sucedidas, o caractere de abertura é removido da pilha.

A expressão é considerada válida se, ao final da iteração, a pilha estiver vazia.

Métodos Privados
AberturaEFechamento: Verifica se um par de caracteres (abertura e fechamento) é correspondente.
Abertura: Verifica se um caractere é uma abertura.
Fechamento: Verifica se um caractere é um fechamento.
