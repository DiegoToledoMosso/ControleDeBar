using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleDeBar.ConsoleApp.ModuloProduto;

public class Produto : EntidadeBase<Produto>
{
    public string Nome { get; set; }
    public string Precos { get; set; }

    public Produto(string nome, string precos)
    {
        Nome = nome;
        Precos = precos;
    }
    

    public override void AtualizarRegistro(Produto registroAtualizado)
    {
        Nome = registroAtualizado.Nome;
        Precos = registroAtualizado.Precos;
    }

    public override string Validar()
    {
        string erros = string.Empty;

        if (Nome.Length < 2 || Nome.Length > 100)
            erros += "O campo \"Nome\" deve conter entre 2 e 100 caracteres.";

        if (!Regex.IsMatch(Precos, @"^\d+(\.\d{1,2})?$"))
            erros += "O campo \"Precos\" deve seguir o padrão : 12.35).";

        return erros;
    }
}
