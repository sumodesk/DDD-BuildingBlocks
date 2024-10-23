using Sumodesk.Domain.Abstractions;

namespace Sumodesk.Domain.Interfaces;

public interface IReadOnlyRespository<TEntity> : IViewRepository<TEntity>
	where TEntity : class, IEntityRoot
{
	bool EnableTracking { get; set; }
	Task<TEntity> GetByIdAsync(int id, IncludeProps<TEntity>? includeProps = default, CancellationToken token = default);
}
