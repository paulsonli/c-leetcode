namespace LeafSimilarTrees {
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
        public bool LeafSimilar(TreeNode root1, TreeNode root2) {

            List<int> list1 = [];
            List<int> list2 = [];

            getLeaves(root1, list1);
            getLeaves(root2, list2);

            return list1.SequenceEqual(list2);
            
            void getLeaves(TreeNode node, List<int> list) {
                if(node.left == null && node.right == null) {
                    list.Add(node.val);
                    return;
                }

                if(node.left != null) getLeaves(node.left, list);
                if(node.right != null) getLeaves(node.right, list);
            }
        }
}
}