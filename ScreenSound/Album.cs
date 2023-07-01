class Album
{
    public string Nome { get; set; }
    public int DuracaoTotal
    {
        get 
        {
            return Musicas.Sum(m => m.Duracao);
        }
    }
    public List<Musica> Musicas { get; set; } = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine("Lista de músicas do álbum: ");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"{musica.Nome}");
        }
    }
}