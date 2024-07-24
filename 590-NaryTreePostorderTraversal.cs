namespace NaryTreePostorderTraversal {
    public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }

    public class Solution {
        public IList<int> Postorder(Node root) {
            // recursive
            // IList<int> results = [];

            // inOrder(root);
            // return results;

            // void inOrder(Node root) {
            //     if(root == null) return;

            //     foreach(Node child in root.children){
            //         inOrder(child);
            //     }
            //     results.Add(root.val);
            // }

            IList<int> results = [];

            Stack<Node> stack = new();
            stack.Push(root);

            while(stack.Count > 0) {
                Node node = stack.Pop();

                if(node != null) {
                    results.Insert(0,node.val);
                    
                    foreach(Node child in node.children) stack.Push(child);
                }
            }

            return results;
            
        }
    }
}