namespace Sumodesk.Domain.Entities;

public abstract class Entity : IEntityId
{
    public int Id { get; protected set; }
}
