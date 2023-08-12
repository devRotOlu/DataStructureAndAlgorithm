namespace DataStructureAndAlgorithm.Sorting
{
    public class TowerOfHanoi<T> where T : IComparable
    {
        private Stack<T> _from = null;

        public Stack<T> From 
        {
            get=> _from;
            set
            {   var stackCount = value.Count;
                var previousItem = value.Peek();
                var isSorted = true;
                if (stackCount > 1)
                {
                    foreach (var item in value)
                    {
                        var sizeIndex = previousItem.CompareTo(item);

                        if (sizeIndex > 0)
                        {
                            isSorted = false;
                        }

                        previousItem = item;
                    }
                }

                if (stackCount <= 1 || !isSorted)
                {
                    throw new ArgumentException("Stack must contain more than one element and they must be sorted in ascending order.");
                }

                _from = value;
            }
        }

        public Stack<T> To { set; get; }
        public Stack<T> Auxilliary { get; set; }

        public TowerOfHanoi(Stack<T> _from)
        {
            From = _from;
            To = new Stack<T>();
            Auxilliary = new Stack<T>();
        }

        public void StackAuxilliary()
        {
            Move(From, To, Auxilliary, From.Count);
        }

        private void Move(Stack<T> from,Stack<T> to,Stack<T> auxilliary,int itemCount)
        {
            if (itemCount > 0)
            {
                Move(from, auxilliary, to, itemCount - 1);
                to.Push(from.Pop());
                Move(auxilliary, to,from, itemCount - 1);
            }
        }
    }
}
