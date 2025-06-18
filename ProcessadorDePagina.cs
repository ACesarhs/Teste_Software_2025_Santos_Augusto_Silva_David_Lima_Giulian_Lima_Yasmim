public class ProcessadorDePagina
{
    private readonly IServicoDePagina _servico;

    public ProcessadorDePagina(IServicoDePagina servico)
    {
        _servico = servico;
    }

    public string TentarObterPaginaDuasVezes(string url)
    {
        // 1ª tentativa
        var conteudo = _servico.ObterConteudo(url);
        
        // se falhar, tenta de novo
        if (string.IsNullOrEmpty(conteudo))
        {
            conteudo = _servico.ObterConteudo(url);
        }

        return conteudo ?? "Falha ao carregar";
    }
}