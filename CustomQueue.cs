namespace DataStructureAndAlgorithm
{
    public class CustomQueue<T> where T : struct
    {
        List<T> list;
        int _count;

        public int Count => _count;

        public CustomQueue()
        {
            list = new List<T>();
            _count = 0;
        }

        public void Enqueue(T data)
        {
            list.Add(data);
            _count++;
        }

        public void Dequeue()
        {
            if (_count == 0)
            {
                return;
            }
            list.RemoveAt(0);
        }

        public T? Peek()
        {
            if (_count == 0)
            {
                return null;
            }

            return list.ElementAt(0);
        }
    }
}
