using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
            List<Pago> pagos = new List<Pago>();

            int opcion;

            do
            {
                Console.WriteLine(" SISTEMA DE PAGOS ");
                Console.WriteLine("1 - Registrar pago con tarjeta");
                Console.WriteLine("2 - Registrar transferencia");
                Console.WriteLine("3 - Mostrar pagos");
                Console.WriteLine("4 - Procesar pagos");
                Console.WriteLine("5 - Salir");
                Console.Write("Opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Titular: ");
                        string titularTarjeta = Console.ReadLine();

                        Console.Write("Monto: ");
                        double montoTarjeta = Convert.ToDouble(Console.ReadLine());

                        pagos.Add(
                            new PagoTarjeta(
                                titularTarjeta,
                                montoTarjeta));

                        Console.WriteLine("Pago con tarjeta registrado.");
                        break;

                    case 2:

                        Console.Write("Titular: ");
                        string titularTransferencia = Console.ReadLine();

                        Console.Write("Monto: ");
                        double montoTransferencia = Convert.ToDouble(Console.ReadLine());

                        pagos.Add(
                            new PagoTransferencia(
                                titularTransferencia,
                                montoTransferencia));

                        Console.WriteLine("Transferencia registrada.");
                        break;

                    case 3:

                        Console.WriteLine(" LISTADO DE PAGOS ");

                        foreach (Pago pago in pagos)
                        {
                            pago.MostrarInformacion();
                            Console.WriteLine("---------------------");
                        }

                        break;

                    case 4:

                        Console.WriteLine(" PROCESANDO PAGOS ");

                        foreach (Pago pago in pagos)
                        {
                            pago.MostrarInformacion();
                            pago.ProcesarPago();
                            Console.WriteLine("---------------------");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:

                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 5);
        }
    }



