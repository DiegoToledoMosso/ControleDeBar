using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;

namespace ControleDeBar.ConsoleApp.ModuloGarcom;

public class TelaGarcom : TelaBase<Garcom>, ITela
{
    public TelaGarcom(RepositorioGarcom repositorioGarcom) : base("Garcom", repositorioGarcom)
    {
    }

    public override void CadastrarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine($"Cadastro de {nomeEntidade}s");

        Console.WriteLine();

        Garcom novoRegistro = ObterDados();

        string erros = novoRegistro.Validar();

        if (erros.Length > 0)
        {
            ApresentarMensagem(
                string.Concat(erros, "\nDigite ENTER para continuar..."),
                ConsoleColor.Red
            );

            CadastrarRegistro();

            return;
        }

        Garcom[] registros = repositorio.SelecionarRegistros();

        for (int i = 0; i < registros.Length; i++)
        {
            Garcom garcomRegistrado = registros[i];

            if (garcomRegistrado == null)
                continue;

            if (garcomRegistrado.Nome == novoRegistro.Nome || garcomRegistrado.Cpf == novoRegistro.Cpf)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Um garçom com este nome já foi cadastrado");
                Console.ResetColor();

                Console.Write("\nDigite ENTER para continuar...");
                Console.ReadLine();

                CadastrarRegistro();

                return;
            }
        }

        repositorio.CadastrarRegistro(novoRegistro);

        ApresentarMensagem($"{nomeEntidade} cadastrado/a com sucesso!", ConsoleColor.Green);
    }

    public override void VisualizarRegistros(bool exibirCabecalho)
    {
        if (exibirCabecalho)
            ExibirCabecalho();

        Console.WriteLine("Visualização de Garçons");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -30} | {2, -30}",
            "Id", "Nome", "Cpf"
        );

        Garcom[] garcom = repositorio.SelecionarRegistros();

        for (int i = 0; i < garcom.Length; i++)
        {
            Garcom g = garcom[i];

            if (g == null)
                continue;            

            Console.WriteLine(
              "{0, -10} | {1, -30} | {2, -30}",
                g.Id, g.Nome, g.Cpf
            );
        }

        ApresentarMensagem("Digite ENTER para continuar...", ConsoleColor.DarkYellow);
    }

    protected override Garcom ObterDados()
    {
        Console.Write("Digite o nome do garçom, nome deve conter no mínimo 3 letras : ");
        string nome = Console.ReadLine();        

        Console.Write("Digite o CPF do garçom, deve seguir o padrão 999.999.999-99 : ");
        string cpf = Console.ReadLine();

        Garcom garcom = new Garcom(nome, cpf);

        return garcom;
    }
}