namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class PascalTriangle
    {
        static public IList<IList<int>> Generate(int rows)
        {
            var list = new List<IList<int>>();
            if (rows <= 0) return list;

            Generate(rows,1,list);
            return list;
        }

        static private void Generate(int maxRowCount,int rowCount, List<IList<int>> list)
        {
            if (rowCount > maxRowCount)
                return;
            var rowList = new List<int>(rowCount);
            for (int i = 0; i < rowCount; i++)
            {
                if (i == 0 || i == (rowCount - 1))
                    rowList.Add(1);
                else rowList.Add(list[rowCount - 2][i] + list[rowCount - 2][i - 1]);
            }
            list.Add(rowList);
            Generate(maxRowCount, rowCount + 1,list);
        }

        static public IList<IList<int>> Generate2(int rows)
        {
            var list = new List<IList<int>>();
            if (rows <= 0) return list;

            for (int line = 0; line < rows; line++)
            {
                var _list = new List<int>();
                for (int j = 0; j <= line; j++)
                    _list.Add(BinomialCoeff(line,j));
                list.Add(_list);
            }
            return list;
        }

        private static int BinomialCoeff(int line, int index)
        {
            int res = 1;

            if (index > (line - index)) index = line - index;

            for (int i = 0; i < index; i++)
            {
                res *= (line - 1);
                res /= (i + 1);
            }
            return res;
        }
    }
}
