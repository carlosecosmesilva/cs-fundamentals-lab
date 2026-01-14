# Algorithms & Data Optimization Lab

Este repositório reúne implementações técnicas focadas em resolução de problemas algorítmicos complexos e otimização de consultas em bancos de dados relacionais. O foco principal é demonstrar **clean code**, **performance** e o uso de recursos modernos das linguagens C# e SQL.

## Desafios e Soluções

### 1. SQL: Análise de Dados Agrupados (Window Functions)

**Objetivo:** Identificar colaboradores com o maior salário por departamento, considerando as tabelas `Pessoa` e `Departamento`.

-   **Abordagem:** Utilizei **Common Table Expressions (CTE)** e a Window Function `RANK()`.
-   **Decisão Técnica:** O uso de `RANK()` em vez de `GROUP BY` permite que o motor do SQL Server identifique o maior valor dentro de cada partição (departamento) sem a necessidade de múltiplas subconsultas, o que reduz o custo de I/O e melhora a legibilidade. Esta abordagem também trata corretamente cenários de empate salarial.

### 2. Algoritmo de Árvore Binária Customizada

**Objetivo:** Construir uma árvore a partir de um array de inteiros sem duplicidade , seguindo regras de hierarquia baseadas no valor máximo e ordenação posicional.

-   **Lógica de Construção:**
-   **Raiz:** O maior valor encontrado no array.

-   **Subárvore Esquerda:** Elementos situados à esquerda da raiz no array original, organizados em ordem decrescente.

-   **Subárvore Direita:** Elementos situados à direita da raiz no array original, organizados em ordem decrescente.

-   **Implementação em C#:** A solução utiliza recursão para a montagem dos galhos e métodos de extensão do **LINQ** (`Max`, `IndexOf`, `Take`, `Skip`) para garantir um código expressivo e imutável.

## Tecnologias Utilizadas

-   **C# (.NET 8):** Implementação de lógica de estruturas de dados.

-   **T-SQL (SQL Server):** Manipulação de dados e queries analíticas.

## Como Executar

1. **SQL:** Execute o script contido na pasta `/sql` em um ambiente SQL Server.
2. **C#:** Certifique-se de ter o SDK do .NET instalado. Execute `dotnet run` dentro do diretório do projeto para validar os cenários de teste fornecidos.
