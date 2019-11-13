using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo3.Ventas
{
    public class Cliente
    {

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private string cédula;
        public string Cédula
        {
            get { return cédula; }
            set { cédula = value; }
        }
        private string dirección;
        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }
    }
}

