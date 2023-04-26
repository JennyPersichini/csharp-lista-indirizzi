// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using csharp_lista_indirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:\\Users\\valer\\OneDrive\\Desktop\\Generetion_Exercises\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");
    int rigacorrente = 0;


    while (!file.EndOfStream)
    {
        rigacorrente++;
        string line = file.ReadLine();

        

    }

    file.Close();

}