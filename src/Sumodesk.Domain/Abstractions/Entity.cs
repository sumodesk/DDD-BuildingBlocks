using Sumodesk.Domain.Interfaces;

namespace Sumodesk.Domain.Abstractions;

public abstract class Entity : IEntityId
{
    public int Id { get; protected set; }
}
