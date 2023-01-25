﻿using API.CatalogosCartaPorte;
using CFDI.API.Enums.CFDI33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace API.Operaciones.ComplementoCartaPorte
{
    [Table("cp_Arrendatario")]
    public class Arrendatario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Nombre del Arrendatario")]
        public String NombreArrendatario { get; set; }

        [DisplayName("Número de Identificación o Registro Fiscal del Arrendatario")]
        public String NumRegIdTribArrendatario { get; set; }

        [DisplayName("Residencia Fiscal del Arrendatario")]
        public c_Pais ResidenciaFiscalArrendatario { get; set; }

        [NotMapped]
        [DisplayName("País")]
        public String Pais { get; set; }

        [DisplayName("RFC del Arrendatario")]
        public String RFCArrendatario { get; set; }

        public int Domicilio_Id { get; set; }
        [ForeignKey("Domicilio_Id")]
        public virtual Domicilio Domicilio { get; set; }

    }
}
