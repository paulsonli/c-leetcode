using System.Security.Cryptography.X509Certificates;

namespace BinaryTreeInorderTraversal {
    public class TreeNode {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution {
        public IList<int> InorderTraversal(TreeNode root) {
            IList<int> result = [];


            //iterative
            //go down all the way left and adding every node to stack, when cant go anymore, add current pointer to result and remove from stack
            //go back to the node that was removed from stack and check right side.
            IList<TreeNode> stack = [];
            TreeNode current = root;

            while(current != null || stack.Count > 0) {
                while(current != null) {
                    stack.Add(current);
                    current = current.left;
                }
                current = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                result.Add(current.val);
                current = current.right;
            }


            //recursive
            //keeps going down the left until null, go back and then add it to result, then check right side and repeat.
            void inorder(TreeNode root) {
                if(root == null) {
                    return;
                }

                inorder(root.left);
                result.Add(root.val);
                inorder(root.right);

            }

            //inorder(root);

            return result;
        }
    }
}