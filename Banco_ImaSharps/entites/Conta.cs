namespace ByteBank.entites
{
    public class Conta
    {
        private string agencia;
        private int numConta;
        private double saldo;

        public Conta(string agencia, int numConta)
        {
            this.agencia = agencia;
            this.numConta = numConta;
        }

        public Conta()
        {
            agencia = "0001";
            numConta = GeradorNumConta();
            saldo = 0;
        }
        private int GeradorNumConta()
        {
            Random ale = new Random();
            int numSorteado = ale.Next(100000, 1000000);
            return numSorteado;
        }
        public string GetAgencia()
        {
            return agencia;
        }
        public int GetNumConta()
        {
            return numConta;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public void ExibiContas(List<Usuario> usuarios, List<Conta> contas)
        {
            if (contas.Count == 0)
            {
                Console.WriteLine("Não há contas cadastradas...");
            }
            else
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    Console.WriteLine($"Nome:{usuarios[i].GetNomeTitular()} | Ag:{usuarios[i].GetConta().agencia} Conta:{usuarios[i].GetConta().numConta}");
                }
            }
        }
        public void QtdContas(List<Conta> contas)
        {
            Console.WriteLine($"Total de contas: {contas.Count}");
        }
    }
}
