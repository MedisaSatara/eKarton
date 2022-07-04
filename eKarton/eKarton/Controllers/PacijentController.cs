using eKarton.Model;
using eKarton.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacijentController : ControllerBase
    {
        private readonly IPacijent _service;

        public PacijentController(IPacijent service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Pacijent>Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Pacijent GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
