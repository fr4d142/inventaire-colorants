using Inventaire_colorant.Infrastructure;
using LiteDB;

namespace Inventaire_colorant
{
    [CollectionName("InventaireColorant")]
    public class InventaireColorant : IDocument
    {
        public string Date { get; set; }

        public int Quantite { get; set; } = 0;

        public string Sku { get; set; }

        public string Nom { get; set; }

        [BsonId]
        public int Id { get; set; }
    }
}