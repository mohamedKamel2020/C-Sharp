namespace FourSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numss = new int[] { 1, 0, -1, 0, -2, 2 };
            Array.Sort(numss);
            IList<IList<int>> result=  FourSum(numss, 0);

            Console.WriteLine(result[0].ToArray());
        }
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 4)
                return result;
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;
            while (left + 1 < right - 1)
            {
                if (nums[left] + nums[left + 1] + nums[right] + nums[right - 1] == target)
                {
                    List<int> OneSolution = new List<int>() { nums[left], nums[left + 1], nums[right - 1], nums[right] };
                    result.Add(OneSolution);
                    left++;
                    right--;
                }
                else if (nums[left] + nums[left + 1] + nums[right - 1] + nums[right] < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            IList<IList<int>> distinctArrays = result
              .GroupBy(arr => string.Join(",", arr))
                .Select(group => group.First())
                 .ToList();   
            return result;

        }


    }
}
