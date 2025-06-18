using Moq;
using Xunit;

public class TestesProcessadorDePagina
{
    [Fact]
    public void TentarObterPaginaDuasVezes_PrimeiraFalha_SegundaFunciona()
    {
        // 1. criando o mock
        var mockServico = new Mock<IServicoDePagina>();

        // 2. configurando o comportamento:
        //   1ª chamada: retorna null (exemplifica a falha)
        //   2ª chamada: retorna "Conteúdo obtido"
        mockServico.SetupSequence(x => x.ObterConteudo("exemplo.com"))
            .Returns(null as string)  // 1ª vez dá em falha
            .Returns("Conteudo obtido"); // 2ª vez dá sucesso

        // 3. cria o processador com o mock
        var processador = new ProcessadorDePagina(mockServico.Object);

        // 4. executa
        var resultado = processador.TentarObterPaginaDuasVezes("exemplo.com");

        // 5. verificando resultado do teste:
        //    - eesultado correto
        //    - método chamado 2x
        Assert.Equal("Conteudo obtido", resultado);
        mockServico.Verify(x => x.ObterConteudo("exemplo.com"), Times.Exactly(2));
    }
}