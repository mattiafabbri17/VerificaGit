using System.ComponentModel;

namespace ConsoleAppClasseScuola
{
    public class Scuola
    {
        private string nome, inidrizzo;
        private double apertura, chiusura;
        public Scuola(string _nome, string _inidrizzo,  double _apertura, double _chiusura)
        {
            nome = _nome;
            inidrizzo = _inidrizzo;
            apertura = _apertura;
            chiusura = _chiusura;
        }
        List<Alunni> scuola = new List<Alunni> ;

        public void AddAlunno(Alunno nome)
        {
            scuola.Add(nome);
        }
        
        public void searchAlunno(Alunno nome, string cognome)
        {
            for(int i = 0; i < scuola.Count; i++)
            {
                if (nome.ToString().cognome == cognome)
                {
                    break;
                }
            }
                
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
