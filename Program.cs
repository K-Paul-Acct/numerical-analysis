SomeEventHandler handler = new();
handler.OnKeyPressed += HandleKeyPressed;
handler.Run();

static void HandleKeyPressed(object? sender, char c)
{
    Console.WriteLine($" you pressed \"{c}\"");
}

class SomeEventHandler
{
    public event EventHandler<char>? OnKeyPressed;

    public void Run()
    {
        var c = Console.ReadKey();
        while (c.Key != ConsoleKey.C)
        {
            OnKeyPressed?.Invoke(this, c.KeyChar);
            c = Console.ReadKey();
        }
    }
}
