/**
 *  Given the head of a sorted linked list, delete all duplicates such 
 *  that each element appears only once. Return the linked list sorted 
 *  as well.
*/

/**
 *  Definition for singly-linked list.
 *  public class ListNode {
 *      public int val;
 *      public ListNode next;
 *      public ListNode(int val=0, ListNode next=null) {
 *          this.val = val;
 *          this.next = next;
 *      }
 *  }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode runner = head;
        while( runner != null )
        {
            if( runner.next != null && runner.val == runner.next.val)
            {
                runner.next = runner.next.next;
            }
            else
            {
                runner = runner.next;
            }
        }
        return head;
    }
}