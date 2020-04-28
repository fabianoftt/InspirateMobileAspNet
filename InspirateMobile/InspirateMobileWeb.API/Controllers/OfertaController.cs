using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InspirateMobile.Infrastructure.Repository;
using InspirateMobileWeb.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InspirateMobileWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly ILogger<OfertaController> _logger;
        private readonly IMapper _mapper;

        public OfertaController(IMapper mapper, ILogger<OfertaController> logger)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Oferta> Get()
        {
            OfertaRepository repository = new OfertaRepository();
            var resultado = repository.Listar().Select(x => _mapper.Map<Oferta>(x));
            //Consulta DAO
            return new List<Oferta>();
        }
    }
}