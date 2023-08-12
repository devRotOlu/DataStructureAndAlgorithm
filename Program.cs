using DataStructureAndAlgorithm.Sorting;
using System.Collections;

namespace DataStructureAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();
            numbers.Push(5);
            numbers.Push(4);
            numbers.Push(3);
            numbers.Push(2);
            numbers.Push(1);
            var towerOfHanoi = new TowerOfHanoi<int>(numbers);
            towerOfHanoi.StackAuxilliary();
            foreach (var number in towerOfHanoi.To)
            {
                Console.WriteLine(number);
            }
        }
    }
}