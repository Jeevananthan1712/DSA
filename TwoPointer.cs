public class TwoPointer
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // int[] result = TwoSum(nums, target);

        // if (result[0] != -1)
        // {
        //     Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        // }
        // else
        // {
        //     Console.WriteLine("No solution found.");
        // }

        // Segregates0and1(new int[] {0, 1, 0, 1,1,0,0,0,1,1,0,0,0,1,1,0,0,0,1,1,1,1, 0, 0, 1, 1, 1, 0});

        Console.WriteLine("unique values -" + RemoveDuplicates(new int[] {0,0,1,1,1,2,2,3,3,4}));
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int sum = nums[left] + nums[right];

            if (sum == target)
            {
                return new int[] { left, right };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new int[] { -1, -1 }; // Return -1 if no solution is found
    }

    public static void Segregates0and1(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int l = nums[left];
            int r = nums[right];

            if(l == 0 && r==1){
                left++;
                right--;
            }
            else if(l==0 && r==0)
                left++;
            else if(l==1 && r == 1)
            {
                right--;
            }
            else if(l==1 && r == 0)
            {
                nums[left] = nums[right];
                nums[right] = l;
                left++;
                right--;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);   
        }

    }

    public static int RemoveDuplicates(int[] nums)
    {
        int left = 0;
        int right = 1;
        int unique = 1;
        while (left <= right && right < nums.Length)
        {
            int rightValue = nums[right];
            if(nums[right-1] == rightValue)
            {
                right++;
            }
            else
            {
                left++;
                nums[left] = rightValue;
                Console.WriteLine(rightValue);
                right++;
                unique++;
            }
        }
        return unique;
    }

    public static int[] SortedSquares(int[] nums)
    {
        int left = nums[]
    }
}