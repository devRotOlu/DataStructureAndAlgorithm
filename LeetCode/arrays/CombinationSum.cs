namespace DataStructureAndAlgorithm.LeetCode.arrays
{
    public class CombinationSum
    {
        // Time Complexity O(n^T)
        // Space Complexity O(T)
        // n is the number of candidates and T is the target value.
        static public IList<IList<int>> GetUniqueCombinations(int[] candidates, int target)
        { 
            //Initialize a list to hold all valid combinations.
            var allCombinations = new List<IList<int>>();

            //Initialize a list to hold the current combinations.
            var currentCombinations = new List<int>();

            //Begin generating combintions with the first candidate number.
            GeneratingCombination(allCombinations,currentCombinations,candidates,target,0);
            return allCombinations;
        }

        private static void GeneratingCombination(List<IList<int>> allCombinations, List<int> currentCombinations, int[] candidates, int remainingTarget, int startIndex)
        {
            // if the ramaining target sum is less than 0, the current combination is not valid; stop exploring this branch.
            if (remainingTarget < 0) return;
            else if (remainingTarget == 0) allCombinations.Add(currentCombinations);
            else
            {
                // Explore all candidate numbers starting frsom the current index
                for (int i = startIndex; i < candidates.Length; i++)
                {
                    // Add the current candidate number to the combination
                    currentCombinations.Add(candidates[i]);

                    // Recursively generate combinations using the remaining target sum.
                    GeneratingCombination(allCombinations,currentCombinations,candidates,remainingTarget - candidates[i],i);

                    // Remove the current candidate number from the combination in order to backtrack and explore other candidate numbers.
                    currentCombinations.Remove(currentCombinations.Count - 1);
                }
            }
        }
    }
}
