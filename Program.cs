class Program
{
    static void Main(string[] args)
    {
        do
        {
            Inicio();
            Console.WriteLine("Deseja realizar outra operação? S para sim e N para não");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() != "S")
                break;

        }
        while (true);
    }

        static void Inicio(){
        var texto = @"selecione o modo de operação:
        1 = Soma
        2 = Subtração
        3 = Multiplicação
        4 = Divisão
        
        OBS:todas as operações serão com dois valores.";
        Console.WriteLine(texto);
        Console.WriteLine("digite o numero que corresponde a operação.");
        int Operacao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite o primeiro valor: ");
        var v1 = Console.ReadLine();
        double valor1 = Convert.ToDouble(v1);

        Console.WriteLine("digite o segundo valor: ");
        var v2 = Console.ReadLine();
        double valor2 = Convert.ToDouble(v2);


        switch (Operacao)
        {
            case 1:
                var resultadoSoma = valor1 + valor2;

                Console.WriteLine($"O resultado é {resultadoSoma}");
            break;

            case 2:
                var resultadoSub = valor1 - valor2;

                Console.WriteLine($"O resultado é {resultadoSub}");
            break;
            
            case 3:
                var resultadoMult = valor1 * valor2;

                Console.WriteLine($"O resultado é {resultadoMult}");
            break;

            case 4:
            if (valor2 != 0 && valor1 != 0)
            {
                var resultadoDiv = valor1 / valor2;
                Console.WriteLine($"O resultado é {resultadoDiv}");
                
            }
            else
            {
                Console.WriteLine("não é possivel realizar divisão com o numero 0");
            }

            break;
            
            default:
                Console.WriteLine("operação invalida!");
            break;
            }
        }
    }