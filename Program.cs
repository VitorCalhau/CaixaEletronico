public class Usuario
{
    string nome;
    string sobrenome;
    string numCartao;
    int pin;
    double saldo;

    public Usuario(string nome, string sobrenome, string numCartao, int pin, double saldo)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.numCartao = numCartao;
        this.pin = pin;
        this.saldo = saldo;
    }
    public string getNome()
    {
        return nome;
    }

    public string getSobrenome()
    {
        return sobrenome;
    }
    public string getNumCartao()
    {
        return numCartao;
    }
    public int getPin()
    {
        return pin;
    }

    public double getSaldo()
    {
        return saldo;
    }

    public void setNome(string newNome)
    {
        nome = newNome;
    }

    public void setSobrenome(string newSobrenome)
    {
        sobrenome = newSobrenome;
    }

    public void setNumCartao(string newNumCartao)
    {
        numCartao = newNumCartao;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setSaldo(double newSaldo)
    {
        saldo = newSaldo;
    }

    public static void Main(string[] args)
    {
        void Opçoes()
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Verificar saldo");
            Console.WriteLine("4 - Sair");
        }

        void deposito(Usuario usuarioAtual)
        {
            Console.WriteLine("O quanto gostaria de depositar ?");
            double deposito = double.Parse(Console.ReadLine());
            usuarioAtual.setSaldo(usuarioAtual.getSaldo() + deposito);
            Console.WriteLine("Obrigado por depositar, seu novo saldo é " + usuarioAtual.getSaldo());
        }

        void saque(Usuario usuarioAtual)
        {
            Console.WriteLine("O quanto gostaria de sacar ?");
            double saque = double.Parse(Console.ReadLine());
            if (saque <= usuarioAtual.getSaldo())
            {
                usuarioAtual.setSaldo(usuarioAtual.getSaldo() - saque);
                Console.WriteLine("Obrigado por sacar, seu novo saldo é " + usuarioAtual.getSaldo());
            }
            else
            {
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
        }

        void saldo(Usuario usuarioAtual)
        {
            Console.WriteLine("seu saldo é " + usuarioAtual.getSaldo());
        }

        List<Usuario> Usuarios = new List<Usuario>();
        Usuarios.Add(new Usuario("Vitor", "Albuquerque", "12345678", 1234, 145));
        Usuarios.Add(new Usuario("Caio", "Savanhago", "87654321", 4321, 121));
        Usuarios.Add(new Usuario("Helen", "Valente", "34512678", 2143, 188));
        Usuarios.Add(new Usuario("Gabriel", "Souza", "12783465", 1243, 655));
        Usuarios.Add(new Usuario("Jeferson", "Teixeira", "21786543", 3412, 789));

        Console.WriteLine("Bem vindo ao Caixa eletronico");
        Console.WriteLine("Por favor insira seu numero de cartão");
        string NumeroCartao;
        Usuario usuarioAtual;

        while (true)
        {
            try
            {
                NumeroCartao = Console.ReadLine();
                usuarioAtual = Usuarios.FirstOrDefault(a => a.numCartao == NumeroCartao);
                if (usuarioAtual != null) { break; }
                else
                {
                    Console.WriteLine("Cartão não reconhecido, tente novamente");
                }
            }
            catch { Console.WriteLine("Cartão não reconhecido, tente novamente"); }
        }

        Console.WriteLine("Por favor insira o Pin de seu cartão");
        int pinUsuario = 0;
        while (true)
        {
            try
            {
                pinUsuario = int.Parse(Console.ReadLine());
                if (pinUsuario == usuarioAtual.getPin()) { break; }
                else
                {
                    Console.WriteLine("Pin não reconhecido, tente novamente");
                }
            }
            catch { Console.WriteLine("Pin não reconhecido, tente novamente"); }
        }

        Console.WriteLine($"Bem vindo {usuarioAtual.getNome()} {usuarioAtual.getSobrenome()}");
        int opção = 0;
        do
        {
            Opçoes();
            try
            {
                opção = int.Parse(Console.ReadLine());
            }
            catch { }
            if (opção == 1) { deposito(usuarioAtual); }
            else if (opção == 2) { saque(usuarioAtual); }
            else if (opção == 3) { saldo(usuarioAtual); }
            else if (opção == 4) { break; }
            else { opção = 0; }
        } while (opção != 4);
        Console.WriteLine("Obrigado por usar !");
        Console.ReadKey();
    }
}









