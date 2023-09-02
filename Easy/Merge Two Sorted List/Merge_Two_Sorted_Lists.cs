using LeetCode.Easy.Merge_Two_Sorted_Lists;

namespace LeetCode.Easy.Merge_Two_Sorted_List;

public class Merge_Two_Sorted_Lists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = list1;

        while (list2 != null)
        {
            if (list2.val < list1.val)
            {
                list1.next = new ListNode(list1.val, list1.next);
                list1.val = list2.val;
                list2 = list2.next;
            }
            else if (list1.next == null)
            {
                list1.next = list2;
                break;
            }
            list1 = list1.next;
        }

        return head;

    }
}
