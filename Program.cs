    Console.WriteLine("--- Entrada Válida ---\n");
    int resposta;
    do 
    {
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    resposta = Convert.ToInt16(Console.ReadLine());
    } while(resposta < 0 || resposta > 9);

    if (resposta == 0)
    {
      Console.WriteLine("\nOperação cancelada.");
    }
    
    else
    {
       Console.WriteLine("\nNúmero selecionado = " + resposta);
    }
    
    mensagemFinal();

    
    void mensagemFinal()
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("\nVolte sempre!");
      Console.ResetColor();
    }