using Sumodesk.Domain.Abstractions;

namespace Sumodesk.Domain.Interfaces;

public interface IViewRepository<TView>
	where TView : class
{
	Task<TView> GetOneAsync(QueryFilter<TView> filter, CancellationToken token = default);
	Task<IReadOnlyList<TView>> GetAllAsync(IncludeProps<TView>? includeProps = default, CancellationToken token = default);
	Task<IReadOnlyList<TView>> GetFilteredAsync(QueryFilter<TView> filter, CancellationToken token = default);
	Task<int> CountAsync(QueryFilter<TView>? filter = default, CancellationToken token = default);
	Task<bool> AnyAsync(QueryFilter<TView>? filter = default, CancellationToken token = default);
}
