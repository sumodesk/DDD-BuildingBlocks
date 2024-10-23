using Sumodesk.Domain.Interfaces;

namespace Sumodesk.Domain.Abstractions;

public abstract class EntityNum : Entity, IEntityId, IEntityNum
{
    public required string Num { get; set; }
}
