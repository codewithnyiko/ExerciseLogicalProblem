namespace EnverSoft.LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
            Console.WriteLine("Common elements in both lists:");
            var list3 = list1.Intersect(list2);
            Console.WriteLine(string.Join(" ", list3));
            Console.WriteLine(); // Add break line

            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"
            Console.WriteLine("Elements from list 1 not found in list 2:");
            var list4 = list1.Where(item => !list2.Contains(item));
            Console.WriteLine(string.Join(" ", list4));
            Console.WriteLine(); // Add break line

            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"
            Console.WriteLine("Elements from list 2 not found in list 1:");
            var list5 = list2.Except(list1);
            Console.WriteLine(string.Join(" ", list5));
            Console.WriteLine(); // Add break line

            Console.WriteLine("Press <ENTER> to continue");
        }
    }
}
