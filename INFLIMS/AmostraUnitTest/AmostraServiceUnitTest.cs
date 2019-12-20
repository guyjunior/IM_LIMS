using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces.Repositories;
using Lims.Domain.Services;
using Lims.Infra.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Lims.UnitTest
{
    [TestClass]
    public class LimsServiceUnitTest
    {
        [TestMethod]
        public void AdicionarAmostraPositiva()
        {
            //Preparação
            IAmostraRepository amostraRepository = new AmostraMemDB();
            var amostraService = new AmostraService(amostraRepository);
            Amostra sample = new Amostra();
            Modalidade sport = new Modalidade();
            Atleta atleta = new Atleta();

            DateTime d = DateTime.Now;
            
            {
                sample.Id = Guid.NewGuid();
                atleta.codAtleta = "522325144";
                sample.DataColeta = d.AddDays(-1);
                atleta.Sexo = "Masculino";
                sample.modalidade = "LOL";
                sample.substancia = "THC";
                sport.susbstancia_proibida = true;
                sample.laudo = "Positivo";
            };

            //Execução
            var result = amostraService.AdicionarAmostra(sample);

            //Validação
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdicionarAmostraNegativa()
        {
            
            IAmostraRepository amostraRepository = new AmostraMemDB();
            var amostraService = new AmostraService(amostraRepository);
            Amostra sample = new Amostra();
            Modalidade sport = new Modalidade();
            Atleta atleta = new Atleta();

            DateTime d = DateTime.Now;
            {
                sample.Id = Guid.NewGuid();
                atleta.codAtleta = "88896696";
                sample.DataColeta = d.AddDays(-1);
                atleta.Sexo = "Masculino";
                sample.modalidade = "LOL";
                sample.substancia = "Sibutramina";
                sport.susbstancia_proibida = false;
                sample.laudo = "Negativo";

            };

            //Execução
            var result = amostraService.AdicionarAmostra(sample);

            //Validação
            Assert.IsFalse(result);
        }
    }
}
