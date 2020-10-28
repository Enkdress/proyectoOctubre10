using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MODELO.PROYECTO
{
    public class MCalculadora
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

        public MCalculadora(double n1, double n2, double r)
        {
            this._Number1 = n1;
            this._Number2 = n2;
            this._Resultado = r;
        }

        public MCalculadora(double n1, double n2)
        {
            this._Number1 = n1;
            this._Number2 = n2;
        }

        public double Potencia() => Math.Pow(this._Number1, this._Number2);
        public double ValorAbsoluto() => Math.Abs(this._Number2);
        public double Factorial()
        {
            double counter = 1;
            for(int i = 1; i <= this._Number1; i++ )
            {
                counter *= i;
            }
            return counter;
        }
        public String Serie1()
        {
            String serie = "";
            for (int i = 1; i <= this._Number2; i++)
            {
                if (i % 2 == 0)
                {
                    serie += " -" + i;
                } else
                {
                    serie += i;
                }
            }

            return serie;
        }
        public int AleatorioFacil()
        {
            int n1 = Int32.Parse(this._Number1.ToString());
            int n2 = Int32.Parse(this._Number2.ToString());
            Random rnd = new Random();

            return rnd.Next(n1, n2);
        }
    }
}
