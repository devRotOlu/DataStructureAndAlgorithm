namespace DataStructureAndAlgorithm
{
    public class PriorityQueueItem
    {
        public int Priority;
        public int Value;
    }
    public class CustomPriorityQueue<T> : Queue<T> where T : PriorityQueueItem 
    {
        public CustomPriorityQueue():base()
        {
           
        }

        public new T Dequeue()
        {
            T[] items;
            int min, minIndex = 0;
            items = this.ToArray();
            min = items[0].Priority;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Priority < min)
                {
                    min = items[i].Priority;
                    minIndex = i;
                }
            }
            this.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                if (i != minIndex) 
                {
                    this.Enqueue(items[i]);
                }
            }

            return items[minIndex];
        }
    }
}
