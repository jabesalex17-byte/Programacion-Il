using ClinicaFC.Application.Dtos.DtoDiagnosis;
using ClinicaFC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaFC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiagnosisController : ControllerBase
    {
        private readonly IDiagnosisServices _service;

        public DiagnosisController(IDiagnosisServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadDiagnosisDto>>> GetAll()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadDiagnosisDto>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add(CreateDiagnosisDto dto)
        {
            await _service.Add(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, CreateDiagnosisDto dto)
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
