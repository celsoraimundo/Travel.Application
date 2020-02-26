using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Travel.Application.Core.Entities;
using Newtonsoft.Json;

namespace Travel.Application.Web.ApiModels
{
    // Note: doesn't expose events or behavior
    public class ViagemDTO
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string NomePassageiro { get; set; }
        public string Origem { get; set; }
        public string Destino{ get; set; }
        public DateTime DataPartida { get; set; }

        public static ViagemDTO From(Viagem item)
        {
            return new ViagemDTO()
            {
                Id = item.Id,
                NomePassageiro = item.NomePassageiro,
                Origem = item.Origem,
                Destino = item.Destino,
                DataPartida = item.DataPartida
            };
        }
    }
}
