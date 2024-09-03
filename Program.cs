
using revisaoConceitosBasicos.Components;


public class Program
{

    public static void Main(string[] args)
    {

        // Criando alguns usuários
        Usuario usuario1 = new("Ana Silva", "123.456.789-00", "Maria Silva", new DateOnly(1990, 5, 15));
        Usuario usuario2 = new("João Pereira", "987.654.321-00", "Laura Pereira", new DateOnly(1985, 8, 22));
        Usuario usuario3 = new("Carlos Souza", "555.555.555-55", "Fernanda Souza", new DateOnly(2000, 1, 30));

        ContaBancaria contaBancaria = new(usuario1);

        contaBancaria.SetSaldo(1800);

        contaBancaria.NovaTransacao(600, usuario2);

        contaBancaria.ImprimirHistorico();
    }

}

