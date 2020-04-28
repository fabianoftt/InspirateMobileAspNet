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
    public class InteresseController : ControllerBase
    {
        private readonly ILogger<InteresseController> _logger;
        private readonly IMapper _mapper;

        public InteresseController(IMapper mapper, ILogger<InteresseController> logger)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Interesse> Get()
        {
            //Consulta DAO
            InteresseRepository repository = new InteresseRepository();
            var resultado = repository.Listar().Select(x => _mapper.Map<InteresseRepository>(x));

            return new List<Interesse>();
        }
    }
}