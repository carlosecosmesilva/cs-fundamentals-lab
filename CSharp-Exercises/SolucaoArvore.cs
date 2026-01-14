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

        int maxVal = nums.Max();
        int maxIndex = Array.IndexOf(nums, maxVal);
        TreeNode root = new TreeNode(maxVal);

        var leftElements = nums.Take(maxIndex)
                               .OrderByDescending(x => x)
                               .ToList();
        root.Left = ConstruirGalhoLinear(leftElements);

        var rightElements = nums.Skip(maxIndex + 1)
                                .OrderByDescending(x => x)
                                .ToList();
        root.Right = ConstruirGalhoLinear(rightElements);

        return root;
    }

    private TreeNode ConstruirGalhoLinear(List<int> elements)
    {
        if (elements == null || !elements.Any())
            return null;

        TreeNode node = new TreeNode(elements[0]);

        node.Left = ConstruirGalhoLinear(elements.Skip(1).ToList());

        return node;
    }
}