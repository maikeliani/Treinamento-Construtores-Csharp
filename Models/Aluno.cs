namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno (string nome, string sobrenome, string disciplina) :base (nome, sobrenome) 
        {
            // : base significa que est apassando os parametros para a classe mãe,
            // o que é uma exigencia para instanciar a classe Pessoa (  o construtor da Pessoa exige 2 parametros: nome e
            //sobrenome), entao aluno precisa obrigatoriamente seguir isso pq ele herda de pessoa
            System.Console.WriteLine(" construtor da classe aluno");

        }
         
    }
}