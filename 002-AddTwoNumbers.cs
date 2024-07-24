using System.Runtime.Intrinsics;

namespace AddTwoNumbers{
    public class Solution {
        public class ListNode {
            public int val;
            public ListNode? next;
            public ListNode(int val=0, ListNode? next=null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2) {
            //dummy node for resulting linknode
            ListNode dummy = new();
            //current pointer is position where we insert a new digit into
            ListNode curPointer = dummy;
            int carry = 0;

            while(l1 != null || l2 != null || carry != 0) {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;

                //add the digit
                int val = v1 + v2 + carry;
                //gets 10s place for carry
                carry = val / 10;
                //gets 1s place
                val %= 10; 

                //insert the value
                curPointer.next = new ListNode(val); 

                //update pointer
                curPointer = curPointer.next;
                if(l1 != null) l1 = l1.next;
                if(l2 != null) l2 = l2.next;
            }
            return dummy.next;
        }
    }
}