class Episodio
{
    public int Numero { get; set; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo
    {
        get
        {
            string convidados = string.Empty;
            if (Convidados.Count() > 0)
            {
                if (Convidados.Count() > 1)
                {
                    for (int i = 0; i < Convidados.Count(); i++)
                    {
                        if (i == Convidados.Count() - 2)
                        {
                            convidados += Convidados[i] + " e " + Convidados[i + 1] + ".";
                            break;
                        }
                        convidados += Convidados[i] + ", ";
                    }
                }
                else
                    convidados = Convidados[0];
            }

            return $"{Titulo} é o episódio de número {Numero}, e traz o(s) convidado(s): {convidados}";
        }
    }
    public List<string> Convidados { get; } = new List<string>();

    public Episodio(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }
}