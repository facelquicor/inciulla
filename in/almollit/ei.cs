public class MyClass
{
    private int[] data;

    public MyClass(int[] input)
    {
        data = (int[])input.Clone(); // defensive copy
    }

    public void Dispose()
    {
        // clean up resources
    }
}

public class Program
{
    public static void Main()
    {
        int[] originalArray = new int[] { 1, 2, 3 };
        MyClass myObject = new MyClass(originalArray);

        // Call Dispose method which will not change the originalArray
        myObject.Dispose();

        // originalArray will remain unchanged
        foreach (int num in originalArray)
        {
            Console.WriteLine(num);
        }
    }
}
