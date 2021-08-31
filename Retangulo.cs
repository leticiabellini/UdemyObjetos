using System;
using System;
using System.Globalization;

namespace UdemyObjetos {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return Largura * 2 + Altura * 2;
        }

        public double Diagonal() {
            double diagonal2 = Largura * Largura + Altura * Altura;
            return Math.Sqrt(diagonal2);
        }

        public override string ToString() {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "PERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
