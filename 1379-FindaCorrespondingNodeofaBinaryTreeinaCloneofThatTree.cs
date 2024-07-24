namespace FindaCorrespondingNodeofaBinaryTreeinaCloneofThatTree {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
            if(original == null) {
                return null;
            }

            if(original == target) {
                return cloned;
            }

            //goes down both trees at the same time and checks if the original matches target
            //if matches, return clone because clone is exact copy
            TreeNode leftResults = GetTargetCopy(original.left, cloned.left, target);

            //
            if(leftResults != null) {
                return leftResults;
            }

            return GetTargetCopy(original.right, cloned.right, target);
        }
    }
}