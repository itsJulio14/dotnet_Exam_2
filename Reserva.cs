using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2
{
    public class Reserva
    {
        public string Responsable { get; set; } = "";
        public Taller Taller { get; set; }
        public int Cantidad { get; set; }
        public string Turno { get; set; } = "";
        public bool Material { get; set; }
        public Reserva(String responsable, Taller taller, int cantidad, string turno, bool material)
        {
            Responsable = responsable;
            Taller = taller;
            Cantidad = cantidad;
            Turno = turno;
            Material = material;
        }
    }
}

