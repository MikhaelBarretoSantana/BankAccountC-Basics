
namespace revisaoConceitosBasicos.Components
{
    public class ContaBancaria
    {
        public Usuario UsuarioHistorico { get; private set; }

        public List<Pagamentos> HistoricoTransacoes { get; private set; }

        public double Saldo { get; private set; }

        public ContaBancaria(Usuario usuario)
        {
            UsuarioHistorico = usuario;
            HistoricoTransacoes = [];
        }

        public void NovaTransacao(double valor, Usuario usuario)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("O valor selecionado é maior que o saldo");
                return;
            }

            Pagamentos pagamentos = new(valor, usuario);

            SetSaldo(Saldo - valor);
            HistoricoTransacoes.Add(pagamentos);
        }

        public void ImprimirHistorico()
        {
            if (HistoricoTransacoes.Count <= 0)
            {
                Console.WriteLine("Não foi efetuada nenhuma transação");
                return;
            }
            else if (HistoricoTransacoes.Count > 0)
            {
                foreach (Pagamentos pagamentos in HistoricoTransacoes)
                {
                    Console.WriteLine($"Foi realizado um pagamento no dia: {pagamentos.Data} no valor de: {pagamentos.Valor} para o CPF: {pagamentos?.Remetente?.Cpf}");
                }
            }
        }

        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                Console.WriteLine("O saldo informado não pode ser negativo");
                return;
            }
            else if (saldo.Equals(Saldo))
            {
                Console.WriteLine("O saldo informado já está definido");
                return;
            }
            else
            {
                Saldo = saldo;
                Console.WriteLine($"Saldo atualizado, o saldo atual é de R$:{saldo}");
                return;
            }
        }

    }

}


