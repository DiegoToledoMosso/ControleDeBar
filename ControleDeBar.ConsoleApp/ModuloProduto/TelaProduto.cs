using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;

namespace ControleDeBar.ConsoleApp.ModuloProduto;

public class TelaProduto : TelaBase<Produto>, ITela
{
    public TelaProduto(RepositorioProduto repositorioProduto) : base("Produto", repositorioProduto)
    {
    }

    public override void CadastrarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine($"Cadastro de {nomeEntidade}s");

        Console.WriteLine();

        Produto novoRegistro = ObterDados();

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

        Produto[] registros = repositorio.SelecionarRegistros();

        for (int i = 0; i < registros.Length; i++)
        {
            Produto produtoRegistrado = registros[i];

            if (produtoRegistrado == null)
                continue;

            if (produtoRegistrado.Nome == novoRegistro.Nome)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uma mesa com este número já está cadastrada");
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

        Console.WriteLine("Visualização de Produtos");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -15}",
            "Id", "Nome", "Preço"
        );

        Produto[] prudutos = repositorio.SelecionarRegistros();

        for (int i = 0; i < prudutos.Length; i++)
        {
            Produto p = prudutos[i];

            if (p == null)
                continue;           

            Console.WriteLine(
              "{0, -10} | {1, -20} | {2, -15}",
                p.Id, p.Nome, p.Valor
            );
        }

        ApresentarMensagem("Digite ENTER para continuar...", ConsoleColor.DarkYellow);
    }

    protected override Produto ObterDados()
    {
        string nome = string.Empty;

        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(nome))
            {
                ApresentarMensagem("Digite um nome válido!", ConsoleColor.DarkYellow);
                Console.Clear();
            }
        }

        bool conseguiuConverterValor = false;

        decimal valor = 0.0m;

        while (!conseguiuConverterValor)
        {
            Console.Write("Digite o valor do produto: ");
            conseguiuConverterValor = decimal.TryParse(Console.ReadLine(), out valor);

            if (!conseguiuConverterValor)
            {
                ApresentarMensagem("Digite um valor numérico válido!", ConsoleColor.DarkYellow);
                Console.Clear();
            }
        }

        return new Produto(nome, valor);
    }
}