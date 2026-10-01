string? continuar;

do{
    Console.WriteLine("====== Pedra, Papel e Tesoura ======");

    Console.WriteLine( "Escolha um número entre: \n 1- Pedra \n 2- Papel \n 3- Tesoura");

    Console.WriteLine("Qual a sua opção? ");
        int escolhaJogador = int.Parse(Console.ReadLine()!);

    string escolhaJogadorTexto = escolhaJogador switch
    {
        1 => "Pedra",
        2 => "Papel",
        3 => "Tesoura",
        _ => "Opção inválida"
    };


    Random random = new Random();

    int escolhaComputador = random.Next(1 , 4);
        string escolhaComputadorTexto = escolhaComputador switch
            {
            1 => "Pedra",
            2 => "Papel",
            3 => "Tesoura",
            _ => "Opção inválida"
            
            };

        if (escolhaJogador == escolhaComputador)
        {
            Console.WriteLine("EMPATE!!!");
        }
            else if ((escolhaJogador == 1 && escolhaComputador == 3) || (escolhaJogador == 2 && escolhaComputador == 1) || (escolhaJogador == 3 && escolhaComputador == 2))
        {   
            Console.WriteLine("VOCÊ GANHOU!!!");
        }
            else
        {
            Console.WriteLine("COMPUTADOR GANHOU!!!");
        }
        
    Console.WriteLine("Você escolheu: " + escolhaJogadorTexto  +  "\n O Computador escolheu: " + escolhaComputadorTexto);

    Console.WriteLine("\n Deseja continuar? (S/N): ");
        continuar = Console.ReadLine();

}
while (continuar?.ToLower() == "s");
