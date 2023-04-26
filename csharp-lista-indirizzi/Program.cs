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

        if (rigacorrente != 1)
        {
            Console.WriteLine(line);
            string[] Listainformazioni = line.Split(',');
            int numeroInformazioni = (Listainformazioni.Length);

            if (numeroInformazioni < 6)
            {
                Console.WriteLine("L'indirizzo a riga " + rigacorrente + " non presenta tutte le informazioni necessarie né la giusta formattazione");
                continue;
            }
            else if (numeroInformazioni > 6)
            {

                if (!char.IsDigit(Listainformazioni[2], 0))
                {
                    string[] nuovaListaInformazioni = new string[6];

                    for (int i = 0; i < Listainformazioni.Length; i++)
                    {
                        if (i == 2)
                        {
                            nuovaListaInformazioni[1] += " " + Listainformazioni[2];
                        }
                        else if (i > 2)
                        {
                            nuovaListaInformazioni[i - 1] = Listainformazioni[i];
                        }
                        else
                        {
                            nuovaListaInformazioni[i] = Listainformazioni[i];
                        }
                    }
                    Listainformazioni = nuovaListaInformazioni;
                }
            }
            else
            {
                for (int i = 0; i < Listainformazioni.Length; i++)
                {
                    if (Listainformazioni[i] == null || Listainformazioni[i] == "")
                    {
                        Listainformazioni[i] = "undefined";
                    }
                }

                Indirizzo indirizzo = new Indirizzo(Listainformazioni[0], Listainformazioni[1], Listainformazioni[2], Listainformazioni[3], Listainformazioni[4], Listainformazioni[5]);
                listaIndirizzi.Add(indirizzo);
            }
        }

    }

    file.Close();

} finally
{

}