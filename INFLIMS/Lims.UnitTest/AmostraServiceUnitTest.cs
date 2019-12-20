using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces;
using Lims.Domain.Services;

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
            var sample = new Amostra
            {
                Id = Guid.NewGuid(),
                Titulo = "Dólar cai a R$3",
                DataPublicacao = DateTime.Now,
                DataExpiracao = DateTime.Now.AddDays(1)
            };

            //Execução
            var result = amostraService.AdicionarAmostra(sample);

            //Validação
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AdicionarAmostraNegativa()
        {
            //Adicionar notícia com data de publicação maior
            //que a data de expiração.
            //Preparação
            IAmostraRepository amostraRepository = new AmostraMemDB();
            var amostraService = new AmostraService(amostraRepository);
            var sample = new Amostra
            {
                Id = Guid.NewGuid(),
                Titulo = "Dólar cai a R$3",
                DataPublicacao = DateTime.Now.AddDays(1),
                DataExpiracao = DateTime.Now
            };

            //Execução
            var result = amostraService.AdicionarAmostra(sample);

            //Validação
            Assert.IsFalse(result);
        }
    }
}
