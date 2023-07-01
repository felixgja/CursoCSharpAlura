class Podcast
{
    public string Host { get; }
    public string Nome { get; }
    public List<Episodio> Episodios { get; } = new List<Episodio>();
    public int TotalEpisodios => Episodios.Count();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodio.Numero = TotalEpisodios + 1;
        Episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome}, apresentado por {Host}");
        foreach (var ep in Episodios)
        {
            Console.WriteLine($"{ep.Numero}º - {ep.Titulo}.");
        }
        Console.WriteLine($"Total de {TotalEpisodios} episódio(s).");
    }
}