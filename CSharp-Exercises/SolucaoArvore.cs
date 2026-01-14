using System;
using System.Collections.Generic;
using System.Linq;

public class TreeNode
{
    public int Val;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int val = 0) { Val = val; }
}

public class SolucaoArvore
{
    public TreeNode ConstruirArvore(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return null;

        int maxIndex = EncontrarIndiceMaior(nums, 0, nums.Length - 1);

        TreeNode root = new(nums[maxIndex]);

        if (maxIndex > 0)
            root.Left = ConstruirGalho(nums, 0, maxIndex - 1);

        if (maxIndex < nums.Length - 1)
            root.Right = ConstruirGalho(nums, maxIndex + 1, nums.Length - 1);

        return root;
    }

    private TreeNode ConstruirGalho(int[] nums, int inicio, int fim)
    {
        if (inicio > fim)
            return null;

        int maxIndex = EncontrarIndiceMaior(nums, inicio, fim);

        TreeNode node = new(nums[maxIndex]);

        if (maxIndex > inicio)
            node.Left = ConstruirGalho(nums, inicio, maxIndex - 1);

        if (maxIndex < fim)
            node.Right = ConstruirGalho(nums, maxIndex + 1, fim);

        return node;
    }

    private int EncontrarIndiceMaior(int[] nums, int inicio, int fim)
    {
        int maxIndex = inicio;
        for (int i = inicio + 1; i <= fim; i++)
        {
            if (nums[i] > nums[maxIndex])
                maxIndex = i;
        }
        return maxIndex;
    }
}