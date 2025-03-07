/*
    O padrão de projeto Iterator  fornece uma maneira de acessar, sequencialmente, 
    os elementos de um objeto agregado sem expor a sua representação subjacente.
*/

// using ITERATOR.MODO_COMUM;
using ITERATOR.MODO_PADRAO;

// List<int> lista = [1, 2, 3, 4, 5, 6, 7, 8, 9]; 
// List<List<int>> matriz = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

// int tamanho  = 9;
// Console.WriteLine("Elementos da lista.");

// for (int i = 0; i < tamanho; i++)
// {
//     Console.Write($"{lista[i]} ");
// }

// int qtdeLinhas = 3;
// int qtdeColunas = 3;

// Console.WriteLine();
// Console.WriteLine("Elementos da matriz.");

// for (int linha = 0; linha < qtdeLinhas; linha++)
// {
//     for (int coluna = 0; coluna < qtdeColunas; coluna++)
//     {
//         Console.Write($"{matriz[linha][coluna]} ");
//     }
// }

// var listaIterator = new ListaIterator(lista);
// var matrizIterator = new MatrizIterator(matriz);

// Console.WriteLine("Elementos da lista.");
// ImpressoraAgregado<int>.Iterar(listaIterator);
// Console.WriteLine("Elementos da matriz.");
// ImpressoraAgregado<int>.Iterar(matrizIterator);

var lista = new Lista(tamanho: 9);
lista.AddItem(1);
lista.AddItem(2);
lista.AddItem(3);
lista.AddItem(4);
lista.AddItem(5);
lista.AddItem(6);
lista.AddItem(7);
lista.AddItem(8);
lista.AddItem(9);
lista.AddItem(10);

var matriz = new Matriz(qtdeLinhas: 3, qtdeColunas: 3);
matriz.AddItem(1);
matriz.AddItem(2);
matriz.AddItem(3);
matriz.AddItem(4);
matriz.AddItem(5);
matriz.AddItem(6);
matriz.AddItem(7);
matriz.AddItem(8);
matriz.AddItem(9);

Console.WriteLine("Elementos da lista.");
ImpressoraAgregado<int>.Iterar(lista);
Console.WriteLine("Elementos da matriz.");
ImpressoraAgregado<int>.Iterar(matriz);