using System;

    public class PagoTarjeta : Pago
    {
        public PagoTarjeta(string titular, double monto)
            : base(titular, monto)
        {
        }

        public override double CalcularComision()
        {
            return 2000;
        }

        public override void ProcesarPago()
        {
            double comision = CalcularComision();

            Console.WriteLine("Procesando pago con tarjeta...");
            Console.WriteLine("Comisión aplicada: $" + comision);
            Console.WriteLine("Monto final: $" + (Monto + comision));
            Console.WriteLine("Pago realizado correctamente.");
        }
    }
