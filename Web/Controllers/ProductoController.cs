using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;
        private readonly IMapper _mapper;

        public ProductoController(IProductoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string name, int marca, int categoria)
        {
            return Ok(_mapper.Map<List<ProductosDTO>>(await _service.GetAllWithSpec(name,marca,categoria)));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<ProductosDTO>(await _service.GetByIdWithSpec(id)));
        }

    }
}
