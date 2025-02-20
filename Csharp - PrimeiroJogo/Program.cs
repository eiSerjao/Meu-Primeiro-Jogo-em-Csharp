


using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;




int TelaInicial()
{


    Console.WriteLine("Jodo da Advinhação");
    Console.WriteLine("1: Iniciar Partida\n2: Sair do Game");
    Console.Write("Escolhe uma alternativa: ");

    string numero1 = Console.ReadLine()!;
    int numero = int.Parse(numero1);
    return numero;
}

int numero = TelaInicial();


while (numero != 1 && numero != 2)
{
    Console.WriteLine("Numero invalido");
    numero = TelaInicial();
}

switch (numero)
{
    case 1:
        Console.WriteLine("Iniciando Partida");
        GameAdivinhação();
        break;
    case 2:
        Console.WriteLine("Até um outro dia");
        break;
}



void GameAdivinhação()
{
    int TelaInicialGame()
    {
        int numeroUsuario = 0;
        string numeroString = "";

        Console.Write("Escolha um numero de 1 a 100: ");
        numeroString = Console.ReadLine()!;
        numeroUsuario = int.Parse(numeroString);
        return numeroUsuario;
    }
    
    int valorUsuario = TelaInicialGame();

    while (valorUsuario !< 1 || valorUsuario !> 100)
    {
        Console.WriteLine("Numero Invalido");
        valorUsuario = TelaInicialGame();
    }

    Random numAleatorio = new Random();
    int valorMaquina = numAleatorio.Next(1, 100);

    ValidarResultado();
    bool Ganhou = ValidarResultado();
    
    if (Ganhou = true)
    {
        Console.WriteLine("1: Jogar denovo\n2: Encerrar Game");
        Console.Write("Qual a sua alternativa: ");
        string resposta = Console.ReadLine()!;
        int numeroResposta = int.Parse(resposta);

        switch (numeroResposta)
        {
            case 1:
                GameAdivinhação();
                break;
            case 2:
                Console.WriteLine("Até Logo");
                break;
        }
    } else
    {
        Console.WriteLine("1: Jogar denovo\n2: Encerrar Game");
        Console.Write("Qual a sua alternativa: ");
        string resposta = Console.ReadLine()!;
        int numeroResposta = int.Parse(resposta);

        switch (numeroResposta)
        {
            case 1:
                GameAdivinhação();
                break;
            case 2:
                Console.WriteLine("Até Logo");
                break;
        }
    }

    bool ValidarResultado()
    {
        bool resultado = false;

        if (valorMaquina > valorUsuario)
        {
            Console.WriteLine("VOCÊ PERDEU!\nA Maquina é a Vencedora!");
            Console.WriteLine($"Numero escolhido pela maquina: {valorMaquina} vs Seu numero: {valorUsuario}");
            resultado = false;
            
        }
        else if (valorUsuario > valorMaquina)
        {
            Console.WriteLine("PARABÊNS VOCÊ GANHOU!");
            Console.WriteLine($"Numero escolhido por você: {valorUsuario} VS Numero da maquina: {valorMaquina}");
            resultado = true;
            
        }
        return resultado;
    }
}

