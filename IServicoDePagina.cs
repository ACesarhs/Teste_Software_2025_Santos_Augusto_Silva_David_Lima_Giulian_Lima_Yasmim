// interface pra definir como um serviço de página deve funcionar
public interface IServicoDePagina
{
    string ObterConteudo(string url);
}

// implementação real (não usamos no teste)
public class ServicoDePagina : IServicoDePagina
{
    public string ObterConteudo(string url)
    {
        // Lógica real (ex.: chamada HTTP)
        return "Conteúdo da página: " + url;
    }
}