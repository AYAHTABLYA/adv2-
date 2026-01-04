namespace assignment;

class Program
{
    static void Main()
    {
   

        // 1️ Bubble Sort Optimized
        int[] arr1 = { 5, 1, 4, 2 };
        Console.WriteLine(" Bubble Sort Optimized:");
        Console.Write("Before: ");
        PrintArray(arr1);
        BubbleSortOptimized(arr1);
        Console.Write("After:  ");
        PrintArray(arr1);
        Console.WriteLine();

        // 2️ Reverse ArrayList In-Place
        List<int> list2 = new List<int> { 10, 20, 30, 40 };
        Console.WriteLine(" Reverse ArrayList In-Place:");
        Console.Write("Before: ");
        PrintList(list2);
        ReverseArrayList(list2);
        Console.Write("After:  ");
        PrintList(list2);
        Console.WriteLine();

        // 3️ Count Numbers Greater Than X
        int[] arr3 = { 11, 5, 3 };
        Console.WriteLine(" Count Numbers Greater Than X:");
        int[] queries3 = { 1, 5, 13 };
        foreach (int x in queries3)
        {
            Console.WriteLine($"X = {x} → Count: {CountGreater(arr3, x)}");
        }
        Console.WriteLine();

        // 4️ Check Palindrome Array
        int[] arr4 = { 1, 3, 2, 3, 1 };
        Console.WriteLine(" Check Palindrome Array:");
        Console.WriteLine(IsPalindrome(arr4) ? "YES" : "NO");
        Console.WriteLine();

        // 5️ Reverse Queue Using Stack
        Queue<int> queue5 = new Queue<int>(new int[] { 1, 2, 3 });
        Console.WriteLine(" Reverse Queue Using Stack:");
        Console.Write("Before: ");
        PrintQueue(queue5);
        ReverseQueue(queue5);
        Console.Write("After:  ");
        PrintQueue(queue5);
        Console.WriteLine();

        // 6️ Balanced Parentheses
        string s6 = "[()]{ }";
        Console.WriteLine(" Balanced Parentheses:");
        Console.WriteLine(IsBalanced(s6.Replace(" ", "")) ? "Balanced" : "Not Balanced");
        Console.WriteLine();

        // 7️ Remove Duplicates from Array
        int[] arr7 = { 1, 2, 2, 3, 4, 4 };
        Console.WriteLine(" Remove Duplicates from Array:");
        int[] result7 = RemoveDuplicates(arr7);
        PrintArray(result7);
        Console.WriteLine();

        // 8️ Remove Odd Numbers from ArrayList
        List<int> list8 = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine(" Remove Odd Numbers from ArrayList:");
        RemoveOdd(list8);
        PrintList(list8);
        Console.WriteLine();

        // 9️ Queue Holds Different Data Types
        Console.WriteLine(" Queue Holds Different Data Types:");
        Queue<object> queue9 = CreateMixedQueue();
        foreach (var item in queue9)
            Console.Write(item + " ");
        Console.WriteLine("\n");

        // 10 Search in Stack
        Stack<int> stack10 = new Stack<int>(new int[] { 5, 8, 2, 1 });
        Console.WriteLine(" Search in Stack (target = 2):");
        SearchStack(stack10, 2);
        Console.WriteLine();

        // 11Intersection of Two Arrays
        int[] arr11a = { 1, 2, 3, 4, 4 };
        int[] arr11b = { 10, 4, 4 };
        Console.WriteLine(" Intersection of Two Arrays:");
        List<int> result11 = Intersection(arr11a, arr11b);
        PrintList(result11);
        Console.WriteLine();

        // 1️2 Subarray with Given Sum
        int[] arr12 = { 1, 2, 3, 7, 5 };
        int target12 = 12;
        Console.WriteLine("Subarray with Given Sum:");
        List<int> sub12 = SubArraySum(arr12, target12);
        PrintList(sub12);
        Console.WriteLine();

        // 1️3 Reverse First K Elements of Queue
        Queue<int> queue13 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
        int k13 = 3;
        Console.WriteLine(" Reverse First K Elements of Queue:");
        Console.Write("Before: ");
        PrintQueue(queue13);
        ReverseFirstK(queue13, k13);
        Console.Write("After:  ");
        PrintQueue(queue13);
        Console.WriteLine();
    }

    

    static void BubbleSortOptimized(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    static void ReverseArrayList(List<int> list)
    {
        int start = 0;
        int end = list.Count - 1;
        while (start < end)
        {
            int temp = list[start];
            list[start] = list[end];
            list[end] = temp;
            start++;
            end--;
        }
    }

    static int CountGreater(int[] arr, int x)
    {
        int count = 0;
        foreach (int num in arr)
            if (num > x) count++;
        return count;
    }

    static bool IsPalindrome(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;
        while (start < end)
        {
            if (arr[start] != arr[end]) return false;
            start++;
            end--;
        }
        return true;
    }

    static void ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0)
            stack.Push(queue.Dequeue());
        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());
    }

    static bool IsBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{') stack.Push(c);
            else
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                    return false;
            }
        }
        return stack.Count == 0;
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);
        return set.ToArray();
    }

    static void RemoveOdd(List<int> list)
    {
        list.RemoveAll(x => x % 2 != 0);
    }

    static Queue<object> CreateMixedQueue()
    {
        Queue<object> queue = new Queue<object>();
        queue.Enqueue(1);
        queue.Enqueue("Apple");
        queue.Enqueue(5.28);
        return queue;
    }

    static void SearchStack(Stack<int> stack, int target)
    {
        int count = 0;
        while (stack.Count > 0)
        {
            count++;
            if (stack.Pop() == target)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
                return;
            }
        }
        Console.WriteLine("Target was not found");
    }

    static List<int> Intersection(int[] a, int[] b)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        List<int> result = new List<int>();
        foreach (int num in a)
        {
            if (!freq.ContainsKey(num)) freq[num] = 0;
            freq[num]++;
        }
        foreach (int num in b)
        {
            if (freq.ContainsKey(num) && freq[num] > 0)
            {
                result.Add(num);
                freq[num]--;
            }
        }
        return result;
    }

    static List<int> SubArraySum(int[] arr, int target)
    {
        int sum = 0, start = 0;
        for (int end = 0; end < arr.Length; end++)
        {
            sum += arr[end];
            while (sum > target)
                sum -= arr[start++];
            if (sum == target)
                return arr[start..(end + 1)].ToList();
        }
        return new List<int>();
    }

    static void ReverseFirstK(Queue<int> queue, int k)
    {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < k; i++)
            stack.Push(queue.Dequeue());
        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());
        int size = queue.Count;
        for (int i = 0; i < size - k; i++)
            queue.Enqueue(queue.Dequeue());
    }

    
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    static void PrintQueue(Queue<int> queue)
    {
        foreach (int num in queue)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}

