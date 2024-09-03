
namespace revisaoConceitosBasicos.Components
{
    public class Historico
    {
        public Usuario UsuarioHistorico { get; private set; }

        public List<Pagamentos> HistoricoTransacoes { get; private set; }

        public double Saldo { get; private set; }

        public Historico(Usuario usuario)
        {
            UsuarioHistorico = usuario;
            HistoricoTransacoes = [];
        }

        public void NovaTransacao()
        {
            Pagamentos pagamentos = new();

            HistoricoTransacoes.Add(pagamentos);
        }

        public void SetSaldo(double saldo) {
            if (saldo < 0) 
            {
                Console.WriteLine("O saldo informado não pode ser negativo");
                return;
            } else if (saldo.Equals(Saldo)) {
                Console.WriteLine("O saldo informado já está definido");
            } else if (!saldo.Equals(saldo) && saldo > 0) {
                Saldo = saldo;
            }
        }

    }

}


