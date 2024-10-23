namespace Sumodesk.Domain.Interfaces;

public interface IRepository<TEntity> : IReadOnlyRespository<TEntity>
	where TEntity : class, IEntityRoot
{
	bool AutoSaveChanges { get; set; }

	Task<TEntity> AddAsync(TEntity entity, CancellationToken token = default);
	Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token = default);
	Task<TEntity> RemoveAsync(TEntity entity, CancellationToken token = default);
}
