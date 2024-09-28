namespace Exercicios;
public class HelloYou
{
    private string Nome;
    private string LastName;

    public void SetFullName()
    {
        Console.WriteLine("Digite seu nome: ");
        Nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");
        LastName = Console.ReadLine();

    }

    public void GetFullName()
    {
        Console.WriteLine($"Olá, {Nome} {LastName}! Seja muito bem-vindo(a)!");
    }
}
