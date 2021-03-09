/*
 *  Given the root of a binary tree, then value v and depth d, you need to add a row of nodes with value v at 
 *  the given depth d. The root node is at depth 1.

 *  The adding rule is: given a positive integer depth d, for each NOT null tree nodes N in depth d-1, create 
 *  two tree nodes with value v as N's left subtree root and right subtree root. And N's original left subtree 
 *  should be the left subtree of the new left subtree root, its original right subtree should be the right 
 *  subtree of the new right subtree root. If depth d is 1 that means there is no depth d-1 at all, then 
 *  create a tree node with value v as the new root of the whole original tree, and the original tree is the 
 *  new root's left subtree.
*/

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

/*
 *  @params
    root: TreeNode
    v: int
    d: int
    @return:
    TreeNode
*/
public class Solution {
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        // if d == 1 we need to make a new root of the tree
        if( d == 1 )
        {
            TreeNode node = new TreeNode(v);
            node.left = root;
            return node;
        }
        // use helper function to add the new row into the tree
        Add(root, v, d - 1);
        // return the tree
        return root;
    }
    
    
    public void Add(TreeNode root, int v, int d)
    {
        // if root doesn't exist we can't possible add anything to this or future depths
        // so we will return to prevent throwing an exception error
        if( root == null ) { return; }
        
        // if d is 1 then we are at the depth before the new row which is where we need to be
        // in order to add a new row in
        if( d == 1 )
        {
            // to add the row we start with the left of the current node by storing it in a temp variable
            // we do this so that when we add the new node in to the left or right we don't lose our reference 
            // to the old node
            // then we will add the new node in to the left of the current node
            // then add the temporarily stored node to the left of newly added node
            // then repeat the process for the right side of the current node
            TreeNode temp = root.left;
            root.left = new TreeNode(v);
            root.left.left = temp;
            temp = root.right;
            root.right = new TreeNode(v);
            root.right.right = temp;
        }
        // if d is not yet 1 we will call the function again with d - 1 to progress towards our end condition
        else
        {
            AddOneRow(root.right, v, d-1);
            AddOneRow(root.left, v, d-1);
        }
        // we do not need to return anything as we are modifying the existing tree
        return;
    }
}