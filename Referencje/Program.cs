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

            List<string> listaGlosow = new List<string>(); 


            var collection = speech.GetInstalledVoices();

            foreach (var item in collection)
            {
                listaGlosow.Add(item.VoiceInfo.Name);
            }

            speech.SelectVoice(listaGlosow.Last());
            


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
