namespace OuvirMusga.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    { 
        int quantidadeDeLetras = (titulo.Length)+2;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '=');
        Console.WriteLine(asteriscos);
        Console.WriteLine($"={titulo}=");
        Console.WriteLine(asteriscos + "\n");
    }
}
