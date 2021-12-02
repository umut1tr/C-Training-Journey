using System;

namespace TESTTESTTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string tier = "Schaf";
            string tier2 = " M'Ä Ä'' ÄÄ ÄÄ Ä Ä ÄÄ Ä Ä ÄÄ Ä Ä H";
            string impfen = " ICH BIN EIN MÄÄÄÄÄHHHHH GEIMPFTES MÄÄ Ä Ä ÄÄ  Ä HH  SCHAAAAAF ";

            Random random = new Random();
            

            for(int i = 0; i < 1001031294; i++)
            {
                int schaefchenzähler = random.Next(1, 4);

                switch (schaefchenzähler)
                {
                    case 1 : Console.WriteLine(tier);
                        break;

                    case 2 : Console.WriteLine(tier2);
                        break;

                    case 3 : Console.WriteLine(impfen);
                        break;
                }
            }
            
        }

        
    }
}
