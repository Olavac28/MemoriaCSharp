struct Ponto
{
    public int x;
    public int y;

    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Program
{
    static void Main()
    {
        Ponto p = new Ponto(1, 2);
        Console.WriteLine(p.y);
    }
}