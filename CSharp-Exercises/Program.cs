using System;
using System.Collections.Generic;
using System.Linq;

SolucaoArvore solucao = new SolucaoArvore();

// Cenário 1
Console.WriteLine("===== CENÁRIO 1 =====");
int[] nums1 = { 3, 2, 1, 6, 0, 5 };
TreeNode raiz1 = solucao.ConstruirArvore(nums1);
Console.WriteLine("Array de entrada: [3, 2, 1, 6, 0, 5]");
Console.WriteLine("Percurso pré-ordem da árvore:");
ExibirArvore(raiz1);
Console.WriteLine("\n");

// Cenário 2
Console.WriteLine("===== CENÁRIO 2 =====");
int[] nums2 = { 7, 5, 13, 9, 1, 6, 4 };
TreeNode raiz2 = solucao.ConstruirArvore(nums2);
Console.WriteLine("Array de entrada: [7, 5, 13, 9, 1, 6, 4]");
Console.WriteLine("Percurso pré-ordem da árvore:");
ExibirArvore(raiz2);
Console.WriteLine("\n");

void ExibirArvore(TreeNode node)
{
    if (node == null)
        return;

    Console.Write(node.Val + " ");
    ExibirArvore(node.Left);
    ExibirArvore(node.Right);
}