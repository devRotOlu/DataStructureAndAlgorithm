using System.Collections;

namespace DataStructureAndAlgorithm
{
    public class CustomSet
    {
        public BitArray data;

        public CustomSet()
        {
            data = new BitArray(10); 
        }

        public void Add(int integer)
        {
            if (IsRequiedLength(integer) == false)
            {
                data.Length = integer + 1;
            }
            data[integer] = true;
        }

        private void Add(bool bitValue,int index)
        {
            if (IsRequiedLength(index) == false )
            {
                data.Length = index + 1;
            }
            data[index] = bitValue;
        }

        public bool IsMember(int integer)
        {
            if (!IsRequiedLength(integer))
            {
                return false;
            }
            return data[integer];
        }

        public void Remove(int integer)
        {
            if (IsRequiedLength(integer) == false)
            {
                return;
            }
            data[integer] = false;
        }

        public CustomSet Union (CustomSet otherSet)
        {
            var tempSet = new CustomSet();
            var loopLength = Math.Max(this.data.Count,otherSet.data.Count);
            for (int i = 0; i < loopLength; i++)
            {
                if (i < this.data.Count && i < otherSet.data.Count)
                {
                    tempSet.Add(this.data[i] || otherSet.data[i],i);
                }
                else if (i >= this.data.Count)
                {
                    tempSet.Add(otherSet.data[i],i);
                }
                else
                {
                    tempSet.Add(this.data[i],i);
                }
            }
            return tempSet;
        }

        public CustomSet Intersection (CustomSet otherSet)
        {
            var tempSet = new CustomSet();
            var loopLength = Math.Min(this.data.Count, otherSet.data.Count);
            for (int i = 0; i < loopLength; i++)
            {
                tempSet.Add(this.data[i] && otherSet.data[i], i);
            }
            return tempSet;
        }

        private bool IsRequiedLength(int integer) => integer + 1 <= data.Count;
    }
}
