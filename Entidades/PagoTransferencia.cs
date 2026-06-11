using System;



    public class PagoTransferencia : Pago
    {
        public PagoTransferencia(string titular, double monto)
            : base(titular, monto)
        {
        }

        public override double CalcularComision()
        {
            return 500;
        }

        public override void ProcesarPago()
        {
            double comision = CalcularComision();

            Console.WriteLine("Procesando transferencia...");
            Console.WriteLine("Comisión aplicada: $" + comision);
            Console.WriteLine("Monto final: $" + (Monto + comision));
            Console.WriteLine("Pago realizado correctamente.");
        }
    }



