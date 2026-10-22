using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public class Taller
    {
        public string Nombre { get; set; } = "";
        public int CupoMaximo { get; set; }

        public Taller (string nombre, int cupoMaximo)
        {
            Nombre = nombre;
            CupoMaximo = cupoMaximo;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
