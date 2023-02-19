using LiteDB;

namespace Inventaire_colorant.Infrastructure
{
    public interface IDocument
    {
        [BsonId]
        public int Id { get; set; }
    }
}
