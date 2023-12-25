int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); //5 2 13 

int n = numbers[0]; // броя на числата , които ще добавим
int s = numbers[1]; // броя на елементите , които ще изтрием
int x = numbers[2];

Stack<int> stack = new Stack<int>(); // празен стек 

int[] numberList = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();//1 13 45 32 4 

for (int i = 0; i < n; i++)
{
    stack.Push(numberList[i]);
}

for (int i = 0; i < s; i++)
{
    stack.Pop();
}
if (stack.Count == 0)
{
    Console.WriteLine("0");
}
else if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}