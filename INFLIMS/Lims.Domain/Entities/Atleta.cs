using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces;
using Lims.Domain.Services;

namespace Lims.Domain.Entities
{
    public class Atleta
    {
        public Guid Id { get; set; }
        public string codAtleta { get; set; }

        public string Sexo { get; set; }
        public string modalidade { get; set; }
    }
}
