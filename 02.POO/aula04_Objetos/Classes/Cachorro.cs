namespace aula04_Objetos.Classes
{
    class Cachorro : Animal
    {
        private string nome;

        public Cachorro(string nome)
        {
            this.nome = nome;
        }

        public void falaNome()
        {
            Console.WriteLine($"o nome é {this.nome}");
        }
    }
}