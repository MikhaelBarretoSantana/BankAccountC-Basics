
using revisaoConceitosBasicos.Components;

public class Pagamentos
{

    public DateTime Data { get; private set; }
    public double Valor { get; private set; }
    public Usuario? Remetente { get; private set; }

    public Pagamentos(double valor, Usuario usuario)
    {
        if (valor < 0)
        {
            Console.WriteLine("O valor do pagamento não pode ser menor que 0");
            return;
        }
        else if (usuario is null)
        {
            Console.WriteLine("Informe o usuario para realizar a transição");
            return;
        }

        Data = DateTime.Now;
        Valor = valor;
        Remetente = usuario;

        Console.WriteLine("Pagamento efetuado!");
    }

}
