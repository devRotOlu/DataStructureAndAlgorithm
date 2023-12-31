﻿using System.Collections;

namespace DataStructureAndAlgorithm
{
    public class BucketHash
    {
        private const int Size = 101;
        ArrayList[] data;

        public BucketHash()
        {
            data = new ArrayList[Size];
            for (int i = 0; i <= Size - 1; i++) 
                data[i] = new ArrayList(4);
        }

        private int Hash(string s)
        {
            long tot = 0;
            char[] charray = s.ToCharArray();

            for (int i = 0; i <= s.Length - 1; i++)
                tot += 37 * tot + (int)charray[i];
            tot = tot % data.GetUpperBound(0);
            if (tot < 0) tot += data.GetUpperBound(0);
            return (int)tot;
        }

        public void Insert(string item)
        {
            int hash_value = Hash(item);
            if (!data[hash_value].Contains(item))
                data[hash_value].Add(item);
        }

        public void Remove(string item)
        {
            int hash_value = Hash(item);
            if (data[hash_value].Contains(item))
                data[hash_value].Remove(item);
        }
    }
}
