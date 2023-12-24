namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class NodeRemoval 
    {
        static public LinkedList<int> RemoveNode (LinkedList<int> linkedList,int nodeData)
        {
            var current = linkedList.First;

            while (current != null)
            {
                if (current.Value.CompareTo(nodeData) == 0)
                {
                    linkedList.Remove(current);
                    return linkedList;
                }
                current = current.Next;
            }
            return linkedList;
        }

        static public ListNode? RemoveNode2 (ListNode head,int nodeData)
        {
            var current = head;

            while (current != null)
            {
                if (current.Value == nodeData)
                {
                    if (current.Previous != null)
                        current.Previous.Next = current.Next;
                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                    return (head.Value == nodeData)? head.Next : head;
                }
                current= current.Next;
            }

            return head;
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode? Next { get; set; }
        public ListNode? Previous { get; set; }

        public ListNode(int value, ListNode? previous = null)
        {
            Value = value;
            Next = null;
            Previous = previous;
        }

        public void AddNext(ListNode next)=> Next = next;
    }
}
