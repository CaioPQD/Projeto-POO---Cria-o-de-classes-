namespace ExercicioPOO
{

    class program
    {
        static void Main(string[] args)
        {
            //Declarando as variaveis do tipo pessoa
            pessoa infopessoa;
            pessoa infopessoa1;

            //Instanciando os objetos
            infopessoa = new pessoa();
            infopessoa1 = new pessoa();

            //Coletando os dados da primeira pessoa
            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome:");
            infopessoa.nome = Console.ReadLine();

            Console.Write("Idade:");
            infopessoa.idade = int.Parse(Console.ReadLine());

            //Coletando os dados da segunda pessoa
            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome:");
            infopessoa1.nome = Console.ReadLine();

            Console.Write("Idade:");
            infopessoa1.idade = int.Parse(Console.ReadLine());

            //Comparando as idades e exibindo o nome da pessoa mais velha
            Console.WriteLine("Pessoa mais velha:");
            if (infopessoa.idade > infopessoa1.idade)
            {
                Console.WriteLine(infopessoa.nome);
            }
            else
            {
                Console.WriteLine(infopessoa1.nome);




            }
        }
    }
}
