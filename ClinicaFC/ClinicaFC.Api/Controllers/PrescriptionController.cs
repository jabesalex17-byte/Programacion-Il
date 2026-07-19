using ClinicaFC.Application.Dtos.DtoPrescription;
using ClinicaFC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaFC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionServices _service;

        public PrescriptionController(IPrescriptionServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadPrescriptionDto>>> GetAll()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadPrescriptionDto>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add(CreatePrescriptionDto dto)
        {
            await _service.Add(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, CreatePrescriptionDto dto)
        {
            await _service.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
