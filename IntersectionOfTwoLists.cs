/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// Write a program to find the node at which the intersection of two singly linked lists begins.
public class Solution {
    // Time Complexity: O(N + M)
    // Space Complexity: O(N)
    // Where N is nodes in list A and M is nodes in list B
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> nodes = new HashSet<ListNode>();
        while(headA != null)
        {
            nodes.Add(headA);
            headA = headA.next;
        }
        
        while(headB != null)
        {
            if(nodes.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
    
    // Time Complexity: O(N)
    // Space Complexity: O(1)

    public ListNode GetIntersection(ListNode headA, ListNode headB)
    {
        if(runnerA == null || runnerB == null)
        {
            return null;
        }
        ListNode runnerA = headA;
        listNode runnerB = headB;
        int lengthA = 0;
        int lengthB = 0;
        while(runnerA != null)
        {
            ++lengthA;
            runnerA = runnerA.next;
        }
        while(runnerB != null)
        {
            ++lengthB;
            runnerB = runnerB.next;
        }
        runnerA = headA;
        runnerB = headB;
        int diff = lengthA - lengthB;
        while(diff>0)
        {
            runnerA = runnerA.next;
            --diff;
        }
        while(diff<0)
        {
            runnerB = runnerB.next;
            ++diff;
        }
        while(runnerA.next != null && runnerB.next != null)
        {
            if(runnerA = runnerB)
            {
                return runnerA;
            }
            runnerA = runnerA.next;
            runnerB = runnerB.next;
        }
        return null;
    }

    //Even better solve
    // in this solution we iterate through each list, and if one pointer hits null before the other
    // it starts back in the other list, this way if there is no connection, after each pointer loops through both lists it will return null
    public ListNode intersection(ListNode a, ListNode b)
    {
        ListNode pointerA = a;
        ListNode pointerB = b;
        while(pointerA != pointerB)
        {
            pointerA = pointerA == null ? b : pointerA.next;
            pointerB = pointerB == null ? a : pointerA.next;
        }

        return pointerA;
    }
}
