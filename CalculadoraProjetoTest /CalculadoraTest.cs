using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraProjeto.Services;

namespace CalculadoraProjetoTest
{
    public class CalculadoraTest
    {
        private Calculadora _calc;

        public CalculadoraTest()
        {
            _calc = new Calculadora();
        }

        [Fact]

        public void TestarSoma()
        {

            int resultado = _calc.Somar(1, 2);

            Assert.Equal(3, resultado);
        }

        [Fact]

        public void TestarSubtracao()
        {
            int resultado = _calc.Subtrair(1, 2);

            Assert.Equal(-1, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calc.Dividir(1, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 2);
            _calc.Somar(1, 3);
            _calc.Somar(1, 4);
            _calc.Somar(1, 5);
            _calc.Somar(1, 6);

            var lista = _calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
