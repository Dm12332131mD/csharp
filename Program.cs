namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int> { 100, 90, 60, 40 };
            List<int> gradesCopy = new List<int> { 100, 90, 60, 40 };
            Console.WriteLine(grades.Count);
            Console.WriteLine(grades.SequenceEqual(gradesCopy));
        }
    }
}