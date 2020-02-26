using Travel.Application.Core.SharedKernel;
using System;

namespace Travel.Application.Core.Entities
{
    public class Viagem : BaseEntity
    {
        public string NomePassageiro { get; set; }
        public DateTime DataPartida{ get; set; }
        public string Origem { get; set; }

        public string Destino { get; set; }

    }
}
