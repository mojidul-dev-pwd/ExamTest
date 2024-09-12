namespace ExamTest
{
    public class ProblemAndSolution
    {
        internal static List<int> FindMatchingElements(int[,,,] array1, int[,,,] array2)
        {
            if (array1.Length < 1 && array2.Length < 1)
                return new List<int>();

            var list = new List<int>();
            var set1 = new SortedSet<int>();
            var set2 = new SortedSet<int>();
            foreach (var element in array1)
            {
                set1.Add(element);
            }

            foreach (var element in array2)
            {
                set2.Add(element);
            }

            foreach (var i in set1)
            {
                if (set2.Contains(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
