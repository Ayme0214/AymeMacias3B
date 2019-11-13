using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo3.Ventas
{
    class Gasolina
    {
        public Gasolina()
        {
            this.iva = 0.12f;
        }

        private float iva;

        public float IVA
        {
            get { return iva; }
            set { iva = value; }
        }


        private string tipo;
        public string Tipo
        {
            get {return tipo; }
            set { tipo = value; }
        }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private void ConocerTipo()
        {
            if (tipo == "EXTRA")
            {
                this.precio = 1.50f;
            }
            if (tipo == "SÚPER")
            {
                this.precio = 2.00f;
            }
        }


        public float Total()
        {
            float total = Subtotal() + Iva();
            return total;
        }

        public float Subtotal()
        {
            ConocerTipo();
            float subtotal = this.cantidad * this.precio;
            return subtotal;
        }

        public float Iva()
        {
            ConocerTipo();
            float iva= Subtotal() * this.iva;
            return iva;
        }
    }
}
