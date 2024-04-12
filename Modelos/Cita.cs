using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121250036_ActividadRADIX.Modelos
{
    public class Cita : EntidadBase
    {
        [Key]
        public int Citaid { get; set; }

        [ForeignKey("Medico")]
        public int Medicoid { get; set; }

        [ForeignKey("Paciente")]
        public int Pacienteid { get; set; }

    }
}
