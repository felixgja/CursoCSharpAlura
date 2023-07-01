class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public GeneroMusical Genero { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence a banda à banda {Artista}.";

    //public string DescricaoResumida
    //{
    //    get
    //    {
    //        return $"A música {Nome} pertence a banda à banda {Artista}.";
    //    }
    //}

    public Musica(string nome, Banda artista, int duracao, GeneroMusical genero, bool disponivel)
    {
        Nome = nome;
        Artista = artista; 
        Duracao = duracao;
        Genero = genero;
        Disponivel = disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+.");
        }
    }
}