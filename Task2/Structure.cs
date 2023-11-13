class Task
{
    public static void Main()
    {
        RGB white;
        white.name = "white";
        white.red = 255;
        white.blue = 255;
        white.green = 255;

        RGB black;
        black.name = "black";
        black.red = 0;
        black.blue = 0;
        black.green = 0;

        white.toConsole();
        black.toConsole();
    }

}
struct RGB
{
    public string name;
    public byte red;
    public byte green;
    public byte blue;
    public void toConsole()
    {
        Console.WriteLine($"{name} ({red}, {green}, {blue})");
    }
}