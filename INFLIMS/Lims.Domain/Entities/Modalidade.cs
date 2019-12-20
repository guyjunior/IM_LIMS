using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces;
using Lims.Domain.Services;

namespace Lims.Domain.Entities
{
    public class Modalidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool substancia_proibida { get; set; }

    }
}
