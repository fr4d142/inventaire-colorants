using Inventaire_colorant.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Inventaire_colorant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventaireColorantController : ControllerBase
    {
        private readonly ILogger<InventaireColorantController> _logger;
        private readonly IRepository<InventaireColorant> _repository;

        public InventaireColorantController(ILogger<InventaireColorantController> logger, IRepository<InventaireColorant> repository)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<InventaireColorant> Get()
        {
            return _repository.GetAll();
        }

        [HttpPut]
        public void Post(string sku)
        {
            var inventaireColorants = _repository.GetAll();
            var inventaireColorantAModifier = inventaireColorants.FirstOrDefault(i => i.Sku == sku);
            if (inventaireColorantAModifier == null)
            {
                var inventaireColorant = new InventaireColorant() { Nom = "Inconnu", Sku = sku, Quantite = 1, Date = DateTime.Now.ToString("yyyy-MM-dd") };
                _repository.Save(inventaireColorant);
                return;
            }

            inventaireColorantAModifier.Quantite = inventaireColorantAModifier.Quantite + 1;
            _repository.Save(inventaireColorantAModifier);
        }

    }
}