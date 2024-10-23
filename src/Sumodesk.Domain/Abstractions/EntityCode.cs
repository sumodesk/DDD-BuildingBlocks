using Sumodesk.Domain.Interfaces;

namespace Sumodesk.Domain.Abstractions;

public abstract class EntityCode : Entity, IEntityCode
{
    public required string Code { get; set; }
}
