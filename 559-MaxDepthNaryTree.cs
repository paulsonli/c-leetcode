namespace MaxDepthOfNaryTree {
    public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}

    public class Solution {
        public int MaxDepth(Node root) {
            if(root == null) return 0;

            Queue<Node> queue = new();
            queue.Enqueue(root);

            int depth = 0;

            while(queue.Count > 0) {
                int queueCount = queue.Count;

                //after it goes through each children, it means it finished with one level
                for(int i = 0; i < queueCount; i++) {
                    Node current = queue.Dequeue();
                    foreach(Node child in current.children){
                        queue.Enqueue(child);
                    }
                }

                depth++;
            }

            return depth;
        }
    }
}