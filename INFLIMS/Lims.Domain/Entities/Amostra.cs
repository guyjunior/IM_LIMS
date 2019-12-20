using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces;
using Lims.Domain.Services;

namespace Lims.Domain.Entities
{
    public class Amostra
    {
        public Guid Id { get; set; }
        public Atleta codAtleta { get; set; }
        public Amostra Sexo { get; set; }
        public string modalidade { get; set; }

        public DateTime DataColeta { get; set; }

        public string laudo { get; set; }

        public string substancia { get; set; }
    }
}
