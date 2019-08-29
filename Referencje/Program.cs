using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Referencje
{
    class Program
    { 
    
        static void Main(string[] args)
        {

            SpeechSynthesizer speech = new SpeechSynthesizer();

            
            


            String zdanie;

            while (true)
            {
                Console.WriteLine("Wpisz zdanie które mam przeczytać");
                zdanie = Console.ReadLine();
                if (zdanie == "x") { break; }
                speech.Speak(zdanie);

                

            }

            
            
            
           

        }

       
        
        


    }
}
