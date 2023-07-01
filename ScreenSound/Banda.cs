class Banda
{
    public string Nome { get; set; }
    public List<Album> Albums { get; set; } = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    private void AdicionarAlbum(Album album)
    {
        Albums.Add(album);
    }

    private void ExibirDiscografia()
    {

    }
}