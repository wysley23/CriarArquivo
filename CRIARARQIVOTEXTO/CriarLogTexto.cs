
namespace CriarLogTexto;

public class EscreverArquivo
{
    public static void EscreverEmArquivo()
    {
        // Caminho do arquivo
        string caminho = "arquivo.txt";

        // Cria ou sobrescreve o arquivo com o StreamWriter
        using (StreamWriter escritor = new StreamWriter(caminho, append: true)) // append: true para adicionar ao arquivo existente
        {
            int i = 0;

            while (i < 5)
            {
                escritor.WriteLine("Escrevendo no arquivo " + i);
                i++;

            }

        }

        Console.WriteLine("Texto escrito no arquivo com sucesso!");
    }
}