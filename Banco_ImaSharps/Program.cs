using ByteBank.entites;
using ByteBank.exception;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Conta conta;
            Usuario usuario;
            Banco banco;
            List<Usuario> usuarios = new List<Usuario>();
            List<Conta> contas = new List<Conta>();
            char op;

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("       Bem-vindo ao ByteBank - O banco que faz seu dinheiro render!");

            do
            {
                try
                {
                    Console.WriteLine("-------------------------------------------------------------------------");
                    MenuPrincipal();
                    op = char.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                catch (Exception e)
                {
                    throw new Excecao("Você deveria digitar uma opção válida... Entre 0 - 7!");
                }
                switch (op)
                {
                    case '1':
                        usuario = new Usuario();
                        usuario.InsercaoUsuario(usuarios, contas);
                        break;

                    case '2':
                        usuario = new Usuario();
                        usuario.RemoverUsuario(usuarios, contas);
                        break;

                    case '3':
                        conta = new Conta();
                        conta.ExibiContas(usuarios, contas);
                        break;

                    case '4':
                        usuario = new Usuario();
                        usuario.ExibeInfoUsuario(usuarios);
                        break;

                    case '5':
                        conta = new Conta();
                        conta.QtdContas(contas);
                        break;

                    case '6':
                        banco = new Banco();
                        banco.SaldoBanco(usuarios);
                        break;

                    case '7':
                        usuario = new Usuario();
                        usuario.LoginUsuario(usuarios, contas);
                        break;

                    case '0':
                        Console.WriteLine("Programa Finalizado!");
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Digite uma opção válida do menu!");
                        break;
                }
            } while (op != '0');
                Console.WriteLine();         
        }
        public static void MenuPrincipal()
        {
            Console.WriteLine("----  Opções disponíveis ----");
            Console.WriteLine("1 - Inserção de novo usuário");
            Console.WriteLine("2 - Exclusão de um usuário");
            Console.WriteLine("3 - Exibir as contas bancárias");
            Console.WriteLine("4 - Exibir dados de um usuário");
            Console.WriteLine("5 - Total de contas");
            Console.WriteLine("6 - Saldo total do banco");
            Console.WriteLine("7 - Login da conta");
            Console.WriteLine("0 - Finalizar programa");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("Digite a opção desejada: ");
        }
    }
}