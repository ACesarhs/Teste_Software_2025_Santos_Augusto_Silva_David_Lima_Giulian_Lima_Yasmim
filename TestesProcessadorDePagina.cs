using Moq;
using Xunit;

public class TestesProcessadorDePagina
{
    [Fact]
    public void TentarObterPaginaDuasVezes_PrimeiraFalha_SegundaFunciona()
    {
        var mockServico = new Mock<IServicoDePagina>();
        int chamadas = 0;

        // implementação da resposta aceita
        mockServico.Setup(x => x.ObterConteudo("exemplo.com"))
            .Returns(() => chamadas++ == 0 ? null! : "Conteudo obtido");

        var processador = new ProcessadorDePagina(mockServico.Object);
        var resultado = processador.TentarObterPaginaDuasVezes("exemplo.com");

        Assert.Equal("Conteudo obtido", resultado);
        mockServico.Verify(x => x.ObterConteudo("exemplo.com"), Times.Exactly(2));
    }
}
