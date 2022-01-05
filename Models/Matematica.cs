namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
          X = x;
          Y = y; 

          Calculadora.EventoCalculadora +=EventHandler; // INSCREVEU O METODO EventHandler NO EVENTO DA CALCULADORA!!

        }



        public void Somar()
        {
            Calculadora.Somar(X,Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("metodo executado!");
        }

    }
}
