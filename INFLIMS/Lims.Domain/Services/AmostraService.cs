using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces.Repositories;
using Lims.Domain.Services;

namespace Lims.Domain.Services
{
    public class AmostraService
    {
        protected IAmostraRepository _amostraRepository;

        
        public AmostraService(IAmostraRepository amostraRepository)
        {
            _amostraRepository = amostraRepository;
        }

        public bool AdicionarAmostra(Amostra sample)
        {
            var sport = new Modalidade();
            var pesquisador = new Analista();

            if (sample.DataColeta > DateTime.Now)
            {
                return false;

            }

            else if (sample.substancia == "Sibutramina" && sample.modalidade == "LOL")
            {
                pesquisador.Nome = "Guy";
                sample.laudo = "Negativo";
                sport.substancia_proibida = false;
                return true;
            }
            else if (sample.substancia == "THC" && sample.modalidade == "LOL")
            {
                pesquisador.Nome = "Tiago";
                sample.laudo = "Positivo";
                sport.substancia_proibida = true;
                return true;
            }



            sample.Id = Guid.NewGuid();

            return _amostraRepository.Create(sample);
        }

        public bool RejeitarAmostra(Amostra samplereject)
        {
            if(samplereject.codAtleta == null)
            {
                return false;
            }

            return _amostraRepository.Update(samplereject);
        }

        public bool DeletarAmostra(Amostra sampledel)
        {
            if (DateTime.Now > sampledel.DataColeta.AddDays(30))
            {
                return false;
            }
            
            return _amostraRepository.Delete(sampledel);
        }


    }
}
