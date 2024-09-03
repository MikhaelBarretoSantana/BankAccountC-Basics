namespace revisaoConceitosBasicos.Components
{
    public class Usuario
    {
        // Propriedades com encapsulamento automático
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public string NomeMae { get; private set; }
        public DateOnly DataNascimento { get; private set; }

        // Construtor
        public Usuario(string nomeCompleto, string cpf, string nomeMae, DateOnly dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            NomeMae = nomeMae;
            DataNascimento = dataNascimento;
        }

        // Métodos para atualização (opcional, dependendo do caso de uso)
        public void SetNomeCompleto(string nomeCompleto) => NomeCompleto = nomeCompleto;
        public void SetCpf(string cpf) => Cpf = cpf;
        public void SetNomeMae(string nomeMae) => NomeMae = nomeMae;
        public void SetDataNascimento(DateOnly dataNascimento) => DataNascimento = dataNascimento;
    }

}
