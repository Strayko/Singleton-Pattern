namespace ConsoleApp2;

public class Singleton
{
    private static Singleton? _instance;

    public Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
            _instance = new Singleton();

        return _instance;
    }
}