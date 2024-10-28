using System.ComponentModel;

namespace ConsoleAppClasseAlunno
{
   
    public class Alunno
    {
        private string nome, cognome, cittàDiResidenza;
        private int età;
        public void alunno(string _nome, string _cognome, string _cittàDiResidenza, int _età )
        {
            nome = _nome;
            cognome = _cognome;
            cittàDiResidenza = _cittàDiResidenza;
            età = _età;
        }        
        public string toString()
        {
            return ($"l'alunno {nome}, {cognome}, residente a {cittàDiResidenza}, con età pari a {età} anni");
        }

        public string classi()
        {
            string fascia = "";
            if(età < 16)
            {
                fascia = "Biennio";
            }
            else
            {
                fascia = "Triennio";
            }
            return fascia;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
