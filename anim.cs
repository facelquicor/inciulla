public class MyClass
{
    public Tuple<int, int, int> tuple { get; set; }
}

var m = new MyClass();
var t = Tuple.Create(1, 2, 3);
m.tuple = t; // Assigning the tuple to the tuple property of object m
Console.WriteLine(m.tuple); // Output: (1, 2, 3)
