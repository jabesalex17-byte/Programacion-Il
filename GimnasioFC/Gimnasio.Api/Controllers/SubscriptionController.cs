using GimnasioFC.Application.Dtos.DtoSubcription;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Domain.Entities;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController(ISubscriptionServices _repo) : ControllerBase
    {

        [HttpGet]

        public async Task<ActionResult<IEnumerable<ReadSubcriptionDto>>> GetAllSubscriptions()
        {
            var subscriptions = await _repo.GetAll();
            return Ok(subscriptions);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<ReadSubcriptionDto>> GetSubscriptionById(int id)
        {
            var subscription = await _repo.GetById(id);
            return Ok(subscription);
        }

        [HttpDelete]

        public async Task<ActionResult> DeleteSubscription(int id)
        {
            await _repo.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> AddSubscription(CreateSubcriptionDto subscription)
        {
            await _repo.Add(subscription);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSubscription(int id, CreateSubcriptionDto subscription)
        {
            await _repo.Update(id, subscription);
            return Ok();
        }
    }
}
