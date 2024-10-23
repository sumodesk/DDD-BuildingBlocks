using Sumodesk.Domain.Abstractions;

namespace Sumodesk.Domain.Interfaces;

public interface IReadUpdateRepository<TEntity>
	where TEntity : class, IEntityRoot
{
	Task<TEntity> GetByIdAsync(int id, IncludeProps<TEntity>? includeProps = default, CancellationToken token = default);
	Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token = default);
}
