/*
    O padrão de projeto Iterator  fornece uma maneira de acessar, sequencialmente, 
    os elementos de um objeto agregado sem expor a sua representação subjacente.
*/

List<int> lista = [1, 2, 3, 4, 5, 6, 7, 8, 9]; 
List<List<int>> matriz = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

int tamanho  = 9;
Console.WriteLine("Elementos da lista.");

for (int i = 0; i < tamanho; i++)
{
    Console.Write($"{lista[i]} ");
}

int qtdeLinhas = 3;
int qtdeColunas = 3;

Console.WriteLine();
Console.WriteLine("Elementos da matriz.");

for (int linha = 0; linha < qtdeLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdeColunas; coluna++)
    {
        Console.Write($"{matriz[linha][coluna]} ");
    }
}