int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> stack = new Queue<int>();
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        stack.Enqueue(nums[i]);


    }

}

Console.WriteLine(string.Join(", ", stack));
