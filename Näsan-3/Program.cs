// Punkt 1
static void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello, World");
    }
}
Hello32();

// Punkt 2
static void Number(int num)
{
    Console.WriteLine(num*num);
}
Number(32);

// Punkt 3
static void Multi(float x, float y)
{
    float result = x*y;
    Console.WriteLine(result);
    return;
}
Multi(5, 2);

// Punkt 4
static void RightTriangleArea(double x, double y)
{
    double result = (x*y)/2;
    Console.WriteLine(result);
    return;
}
RightTriangleArea(2, 4);

// Punkt 5
static void CircleArea(float x)
{
    float result = x*x*3;   // pi = 3
    Console.WriteLine(result);
    return;
}
CircleArea(4);

// Punkt 6
static void GetNumberInput()
{
    bool success = false;
    while (success != true)
    {
        string answer = Console.ReadLine();
        int right;
        success = int.TryParse(answer, out right);
    }
    return;
}
GetNumberInput();

// Punkt 7
static void GetChoice (string a, string b, string c)
{
    bool lyckad = false;
    while (lyckad != true)
    {
        Console.WriteLine("1) " + a + " 2) " + b + " 3) " + c);
        Console.WriteLine("Please choose 1, 2 or 3");
        string choice = Console.ReadLine();
        int number;
        lyckad = int.TryParse(choice, out number);
    }
    return;
    
}
GetChoice("water", "melon", "sugar");

Console.ReadLine();