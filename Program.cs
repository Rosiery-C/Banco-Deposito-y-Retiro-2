using System;

namespace Banco_Deposito_y_Retiro
{
    public class CuentaBancaria
    {
        public string Titular_Cta;
        public string Cuit;
        public decimal Saldo;
        public long Numero_CBU;

        public CuentaBancaria(string Usuario, string No_Cuenta, decimal Balance, long Tarjeta)
        {
            Titular_Cta = Usuario;
            Cuit = No_Cuenta;
            Saldo = Balance;
            Numero_CBU = Tarjeta;
        }

        public void Deposito (decimal r)
        {
            Saldo = Saldo + r;
        }

        public void Retiro (decimal b)
        {
            Saldo = Saldo + b;
        }

        public decimal Saldo_Cuenta ()
        {
           return Saldo;
        }
        public void Mostrar()
        {
            Console.WriteLine(Titular_Cta+ " " + "Su balance actual es\n" + "" +  Saldo);
        }
    }

    class Banco
    {
        public CuentaBancaria Cliente_01, Cliente_02, Cliente_03;

        public Banco()
        {
            Cliente_01 = new CuentaBancaria("Juan Alonso", "20-26987456-7", (decimal) 1258.75, 1236547896554);
            Cliente_02 = new CuentaBancaria("Alberto Lopez", "23-15654321-9", (decimal) 25698.78, 9876546546557);
            Cliente_03 = new CuentaBancaria("Park Jimin", "25-34298641-2", (decimal) 50645.50, 2309476209612);
        }

        public void Operar()
        {
            Cliente_01.Deposito((decimal) 45680.34);
            Cliente_02.Deposito((decimal) 12345.56);
            Cliente_03.Deposito((decimal) 26543.34);
            Cliente_02.Retiro((decimal) 550.00);
            Cliente_01.Retiro((decimal) 2450.00);
            Cliente_03.Retiro((decimal) 4550.00);
        }

        public void Totales_Operaciones()
        {
            decimal r = (decimal)((decimal)Cliente_01.Saldo_Cuenta() + Cliente_02.Saldo_Cuenta() + Cliente_03.Saldo_Cuenta());
            Console.WriteLine("Total Depositos del Dia\n" + r);
            Cliente_01.Mostrar();
            Cliente_02.Mostrar();
            Cliente_03.Mostrar();
        }
        static void Main(string[] args)
        {
            Banco Banco_principal = new Banco();
            Banco_principal.Operar();
            Banco_principal.Totales_Operaciones();
            Console.ReadKey();
        }
    }
}
