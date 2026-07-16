using GimnasioFC.Domain.Entities;
using GimnasioFC.Domain.Repository;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionRepository _repo;

        public SubscriptionController(ISubscriptionRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Subscription>>> GetAllSubscriptions()
        {
            var subscriptions = await _repo.GetAll();
            return Ok(subscriptions);
        }

        [HttpDelete]

        public async Task<ActionResult> DeleteSubscription(int id)
        {
            await _repo.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> AddSubscription(Subscription subscription)
        {
            await _repo.Add(subscription);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSubscription(int id, Subscription subscription)
        {
            await _repo.Update(id, subscription);
            return Ok();
        }
    }
}
