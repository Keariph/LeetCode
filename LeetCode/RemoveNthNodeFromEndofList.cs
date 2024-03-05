using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * [Задача на leetcode](https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/)
 **/
namespace LeetCode
{
    public class RemoveNthNodeFromEndofList
    {
        public RemoveNthNodeFromEndofList() { }

        public ListNode Solution(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (n != 0) 
            {
                fast = fast._next;
                n--;
            }
            if(fast == null)
            {
                return head._next;
            }

            while (fast._next != null)
            {
                slow = slow._next;
                fast = fast._next;
            }

            slow._next = slow._next._next;
            return head;
        }
    }

    public class ListNode
    {
        public int _val;
        public ListNode _next;

        public ListNode(int val = 0, ListNode next = null)
        {
            _val = val;
            _next = next;
        }
    }
}
