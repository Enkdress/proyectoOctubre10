using System;
using MODELO.PROYECTO;

namespace CONTROL.PROYECTO
{
    public class CCalculadora
    {
        MCalculadora mcalculo;
        public CCalculadora(double n1, double n2) {
            mcalculo = new MCalculadora(n1, n2);
        }
        public double sumarNumeros() {
            return mcalculo.Sumar();
        }
        public double moduloNumeros() {
            return mcalculo.Modulo();
        }
        public double potenciaNumeros() {
            return mcalculo.Potencia();
        }
        public double mayorNumeros() {
            return mcalculo.NMayor();
        }
        public String serieNumeros1() {
            return mcalculo.Serie1();
        }
        public String serieNumeros2() {
            return mcalculo.Serie2();
        }
        public double factorialNumeros() {
            return mcalculo.Factorial();
        }
        public int aleatoriosNumeros() {
            return mcalculo.AleatorioFacil();
        }
        public double sumatoriaNumeros() {
            return mcalculo.Sumatoria();
        }
        public double absolutoNumeros() {
            return mcalculo.ValorAbsoluto();
        }
    }
}
