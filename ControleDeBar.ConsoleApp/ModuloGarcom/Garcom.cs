using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleDeBar.ConsoleApp.ModuloGarcom;

public class Garcom : EntidadeBase<Garcom>
{
    public string Nome { get; set; }
    public string Cpf { get; set; }   

    public Garcom(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;       
    }

    public override void AtualizarRegistro(Garcom registroAtualizado)
    {
        Nome = registroAtualizado.Nome;
        Cpf = registroAtualizado.Cpf;
    }

    public override string Validar()
    {
        string erros = string.Empty;

        if (Nome.Length < 3 || Nome.Length > 100)
            erros += "O campo \"Nome\" deve conter entre 3 e 100 caracteres.";        

        if (!Regex.IsMatch(Cpf, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$"))
            erros += "O campo \"CPF\" deve seguir o padrão 999.999.999-99).";

        return erros;
    }
}
