namespace DataStructureAndAlgorithm
{
    public class CustomStack<T> where T : struct
    {
        private List<T> data;
        private int dataLength;

        public int Count
        { 
            get
            {
                if (dataLength == -1)
                {
                    return 0;
                }
                return dataLength + 1;
            }
        }

        public CustomStack()
        {
            data = new List<T>();
            dataLength = -1;
        }

        public void Push(T value)
        {
            data.Add(value);
            dataLength++;
        }

        public T? Pop()
        {
            if (dataLength == -1)
            {
                return null;
            }
            var value = data[dataLength];
            data.RemoveAt(dataLength);
            dataLength--;
            return value;
        }

        public T? Peek()
        {
            if (dataLength == -1)
            {
                return null;
            }
            return data[dataLength];
        }

        public void Clear()
        {
            data.Clear();
            dataLength = -1;
        }
    }
}
