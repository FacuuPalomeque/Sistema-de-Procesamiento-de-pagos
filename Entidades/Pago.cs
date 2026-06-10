using System;
s
    public abstract class Pago
    {
        private string titular;
        private double monto;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public Pago(string titular, double monto)
        {
            Titular = titular;
            Monto = monto;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Monto original: $" + Monto);
        }

        public abstract double CalcularComision();

        public abstract void ProcesarPago();
    }
