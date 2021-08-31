using System.Globalization;
using System.Globalization;

namespace UdemyObjetos {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            double aumento = SalarioBruto * (porcentagem / 100);
            SalarioBruto += aumento;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
