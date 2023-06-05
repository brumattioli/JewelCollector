using JewelCollector;
using System.Collections.Concurrent;

// A classe JewelCollector deverá ser responsável por implementar o método Main(), criar o mapa, inserir as joias, obstáculos,
// instanciar o robô e ler os comandos do teclado. Para que o usuário possa controlar o robô, os seguintes comandos deverão ser
// passados através das teclas w, s, a, d, g. Sendo que a tecla w desloca o robô para o norte, a tecla s desloca para o sul, a
// tecla a desloca para oeste e a tecla d para leste. Para coletar uma joia, use a tecla g.
static void Main()
{
    bool running = true;

    // Criação do Mapa
    Map mapa = new Map();
    mapa.tab = new object[10,10];
    Empty vazio = new Empty();
    
    for (int i=0; i<10; i++) //Linha
    { 
        for (int j=0; j<10; j++) //Coluna
        {
            mapa.tab[i, j] = vazio.Print();
        }
    }

    // Inserir os objetos/obstáculos
    Obstacle tree1 = new Obstacle(5, 9, "Tree");
    mapa.tab[5, 9] = tree1.Print();

    for (int i = 0; i < 10; i++) //Linha
    {
        for (int j = 0; j < 10; j++) //Coluna
        {
            Console.Write(mapa.tab[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine("Bag total items: $ | Bag total value: $");
    Console.WriteLine();





    /*
    // Inserir as joias, criando objetos da classe Jewel
    Jewel red1 = new Jewel(1, 9, "Red");
    Jewel red2 = new Jewel(8,8,"Red");
    Jewel green1 = new Jewel(9,1,"Green");
    Jewel green2 = new Jewel(7,6,"Green");
    Jewel blue1 = new Jewel(3,4,"Blue");
    Jewel blue2 = new Jewel(2,1,"Blue");

    //red1.Print(); red2.Print(); green1.Print(); green2.Print(); blue1.Print(); blue2.Print();

    // Inserir os objetos/obstáculos, criando objetos da classe Obstacle
    // Obstacle water1 = new Obstacle(5,0,"Water");
    // Obstacle water2 = new Obstacle(5,1,"Water");
    // Obstacle water3 = new Obstacle(5,2,"Water");
    // Obstacle water4 = new Obstacle(5,3,"Water");
    // Obstacle water5 = new Obstacle(5,4,"Water");
    // Obstacle water6 = new Obstacle(5,5,"Water");
    // Obstacle water7 = new Obstacle(5,6,"Water");
    // Obstacle tree1 = new Obstacle(5,9,"Tree");
    // Obstacle tree2 = new Obstacle(3,9,"Tree");
    // Obstacle tree3 = new Obstacle(8,3,"Tree");
    // Obstacle tree4 = new Obstacle(2,5,"Tree");
    // Obstacle tree5 = new Obstacle(1,4,"Tree");

    // Instanciar o robô
    //robot(0,0);
    */
    do
    {
        // Ler os comandos do teclado para o robô se mover na tela
        //Chamar o método da classe Map a cada vez que uma nova tecla é apertada

        Console.WriteLine("Enter the command: ");
        string command = Console.ReadLine();

        if (command.Equals("quit"))
        {
            running = false;
        }
        else if (command.Equals("w"))
        {

        }
        else if (command.Equals("a"))
        {

        }
        else if (command.Equals("s"))
        {

        }
        else if (command.Equals("d"))
        {

        }
        else if (command.Equals("g"))
        {

        }
    } while (running); 
}
Main();