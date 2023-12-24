namespace DataStructureAndAlgorithm.LeetCode.Easy
{
    public class LinkedListDigits
    {
        public static LinkedList<int> AddTwoNumbers1(LinkedList<int> list1, LinkedList<int> list2)
        {
            var currentNumber1 = list1.Last;
            var currentNumber2 = list2.Last;
            var loopLength = list1.Count > list2.Count? list1.Count : list2.Count;
            int sum;
            int carry = 0;
            var linkedListArray = new List<int>();
          
            for (int i = 0; i < loopLength; i++)
            {
               sum = (((currentNumber1?.Value) ?? 0) + ((currentNumber2?.Value) ?? 0) + carry) % 10;

                carry = (((currentNumber1?.Value) ?? 0) + ((currentNumber2?.Value) ?? 0) + carry) / 10;
                linkedListArray.Add(sum);
                currentNumber1 = currentNumber1?.Previous;
                currentNumber2 = currentNumber2?.Previous;
            }

            if (carry != 0)
            {
                linkedListArray.Add(carry);
            }

            return new LinkedList<int>(linkedListArray);
        }

        static public LinkedList<int> ? AddTwoNumbers2(LinkedList<int> list1, LinkedList<int> list2)
        {
            if (list1 == null || list2 == null)
            {
                return null;
            }
            var lastNode1 = list1.Last;
            var lastNode2 = list2.Last;
            int carry = 0;
            var list = new List<int>();
            return new LinkedList<int>(AddNumbers(lastNode1!, lastNode2!, carry, list));
        }

        static private List<int> AddNumbers(LinkedListNode<int> node1, LinkedListNode<int> node2, int carry, List<int> linkedList)
        {
            var sum = (((node1?.Value) ?? 0) + ((node2?.Value) ?? 0) + carry) % 10;

            carry = (((node1?.Value) ?? 0) + ((node2?.Value) ?? 0) + carry) / 10;

            linkedList.Add(sum);

            if (node1?.Previous != null || node2?.Previous != null)
            {
                return AddNumbers(node1?.Previous!, node2?.Previous!, carry, linkedList);
            }
            else if(carry != 0)
            {
                linkedList.Add(carry);
            }

            return linkedList;
        }
    }
}
