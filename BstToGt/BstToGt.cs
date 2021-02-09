/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int sumRight = 0;
    public TreeNode ConvertBST(TreeNode root) {
        // first we need to check that root contains values
        if(root == null) 
        { 
            return root; 
        }

        // first we want to scale all the elements to the right
        if(root.right != null) 
        { 
            ConvertBST(root.right); 
        }

        // then at each element add that value to the sum
        sumRight += root.val;

        // the new sum is equal to what our current value needs to become
        root.val = sumRight;

        // then once we have done all the summing for the right side of the node
        // we can look to the left side and continue to operate on each node the same way
        if(root.left != null) 
        { 
            ConvertBST(root.left); 
        }

        return root;
    }
}