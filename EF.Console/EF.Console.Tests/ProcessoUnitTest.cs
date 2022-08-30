using System;
using Xunit;

namespace EF.Console.Tests
{
    public class ProcessoUnitTest
    {
        [Fact]
        public void getProcesso_RunningProcess_ReturnOk()
        {
            // Arrange - Preaparação
            var processo = new Processo();
            var valorEsperado = "Processo rodando...";

            // Act - Execução
            var result = processo.getProcesso();

            // Assert - Resultado
            Assert.Equal(result, valorEsperado);
        }
    }
}
