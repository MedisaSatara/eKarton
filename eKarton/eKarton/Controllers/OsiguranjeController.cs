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
    public class OsiguranjeController : ControllerBase
    {
        private readonly IOsiguranje _service;

        public OsiguranjeController(IOsiguranje service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Osiguranje> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Osiguranje GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
