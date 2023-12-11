using System;
using System.ComponentModel;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            deck myDeck = new deck ("monSuperDeckDeLaMortQuiTue");

            Carte MyCarte = new Carte("bidule");
            Carte MyCarte2 = new Carte("bidulo");

            myDeck.AddCarte(MyCarte);
            myDeck.AddCarte(MyCarte2);
        }
    }
    class deck
    
    {
        public void AddCarte(Carte carte)
        {
            carteList.Add(carte);

        }
        public deck(string p_deckName) 
        { 
            deckName = p_deckName;
        }
        private List<Carte> carteList = new List<Carte>();
        private string deckName ;
        
        
    }
    class Carte 
    {
       

        public Carte(string p_carteName)
        {
            carteName = p_carteName;
        }
        
        private string carteName; 
    
    
    
    }









    

    
    


     


   /* internal class Program
    {
       /* static bool contains(List<string> myliste , string toFind ) 
        {
            for (int start = 0; start < myliste.Count; start++)
            {

                Console.WriteLine(myliste[start]);
                if (toFind == myliste[start])
                {
                    return true;
                }
            }
           return false;    
        }*/
       /* static void Main(string[] args)
        {
           /* List<string> alphabet = new List<string> { "a", "b", "c", "d", "e" };

            List<string> answer = new List<string> { "a", "b" };
            int success = 0;

            while (success < answer.Count)
            {
                Console.WriteLine("guess letter between a to e");
                string result = Console.ReadLine();
                if (contains(alphabet, result))
                {

                    if (result == answer[0])
                    {
                        Console.WriteLine("GG well played");
                        success++;
                    }
                }
                else
                {
                    Console.WriteLine("not found");
                }

            }*/

            /*List<string> myliste = new List<string>();
             myliste.Add("tata");
             myliste.Add("toto");
             myliste.Add("didi");
             myliste.Add("rere");
             myliste.Add("michemiche");

             string toFind = "tata";




             for (int start = 0; start < myliste.Count; start++)
             {

                 Console.WriteLine(myliste[start]);
                 if (toFind == myliste[start])
                 {
                     Console.WriteLine("VariableFound");
                 }
             }*/





        
    
}


 



    


                    
            



        
    



