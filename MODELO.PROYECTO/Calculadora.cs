using System;

namespace MODELO.PROYECTO
{
    public class Calculadora
    {
        private double _Number1;
        public double Number1
        {
            get => _Number1;
            set => _Number1 = value;
        }

        private double _Number2;
        public double Number2
        {
            get => _Number2;
            set => _Number2 = value;
        }

        private double _Resultado;
        public double Resultado
        {
            get => _Resultado;
            set => _Resultado = value;
        }

        public Calculadora(double n1, double n2, double r)
        {
            this._Number1 = n1;
            this._Number2 = n2;
            this._Resultado = r;
        }
    }
}
