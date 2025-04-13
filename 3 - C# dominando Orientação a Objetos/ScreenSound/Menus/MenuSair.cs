
namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public static void Executar()
    {
        Console.WriteLine("Tchau tchau :)");
        Thread.Sleep(2000);
    }
}