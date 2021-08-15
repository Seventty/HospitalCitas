﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital_Citas_B.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Cita = new HashSet<Citas>();
        }

        public int Iddoctor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public virtual ICollection<Citas> Cita { get; set; }
    }
}
