using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces.Repositories;
using Lims.Domain.Services;
using Lims.Infra.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lims.UnitTest
{
    [TestClass]
    public class AmostraServiceUnitTest
    {
        [TestMethod]
        public void AdicionarAmostraPositiva()
        {
            //Preparação
            IAmostraRepository amostraRepository = new AmostraMemDB();
            var amostraService = new AmostraService(amostraRepository);
            var sample = new Amostra();
            var sport = new Modalidade();
            var atleta = new Atleta();

            DateTime d = DateTime.Now;

            {
                sample.Id = Guid.NewGuid();
                atleta.codAtleta = "522325144";
                sample.DataColeta = d.AddDays(-9);
                atleta.Sexo = "Masculino";
                sample.modalidade = "LOL";
                sample.substancia = "THC";

            };


            var ams = amostraService.AdicionarAmostra(sample);

            //Validação
            Assert.IsTrue(ams);
        }

        [TestMethod]
        public void AdicionarAmostraNegativa()
        {

            IAmostraRepository amostraRepository = new AmostraMemDB();
            var amostraService = new AmostraService(amostraRepository);
            Amostra sample = new Amostra();
            Atleta atleta = new Atleta();

            DateTime d = DateTime.Now;
            {
                sample.Id = Guid.NewGuid();
                atleta.codAtleta = "88896696";
                sample.DataColeta = d.AddDays(-4);
                atleta.Sexo = "Masculino";
                sample.modalidade = "LOL";
                sample.substancia = "Sibutramina";


            };


            var ams = amostraService.AdicionarAmostra(sample);

            //Validação
            Assert.IsTrue(ams);
        }
        [TestMethod]
        public void RejeitarAmostraFaltaInfo()
        {

            IAmostraRepository amostraRepository = new AmostraMemDB();
            var rejeitarAmostra = new AmostraService(amostraRepository);
            Amostra sample = new Amostra();
            Atleta atleta = new Atleta();

            DateTime d = DateTime.Now;
            {
                sample.Id = Guid.NewGuid();
                atleta.codAtleta = null;
                sample.DataColeta = d.AddDays(-8);
                atleta.Sexo = "Masculino";
                sample.modalidade = "Futebol";
                sample.substancia = "";


            };


            var ams = rejeitarAmostra.RejeitarAmostra(sample);

            //Validação
            Assert.IsFalse(ams);

        }
        [TestMethod]
        public void DeletarAmostraComTempo()
        {

            IAmostraRepository amostraRepository = new AmostraMemDB();
            var deletarAmostra = new AmostraService(amostraRepository);
            Amostra sample = new Amostra();
            Atleta atleta = new Atleta();

            DateTime d = DateTime.Now;
            {
                sample.Id = Guid.NewGuid();
                atleta.codAtleta = "775235475";
                sample.DataColeta = d.AddDays(-30);
                atleta.Sexo = "Masculino";
                sample.modalidade = "Futebol";
                sample.substancia = "Hidroclorotiazida";


            };


            var ams = deletarAmostra.DeletarAmostra(sample);

            //Validação
            Assert.IsFalse(ams);

        }

    }
}
