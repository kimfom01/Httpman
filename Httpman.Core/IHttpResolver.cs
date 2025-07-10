namespace Httpman.Core;

public interface IHttpResolver
{
    public Task<Result> MakeRequest(string urlString, object? body, RequestType requestType, CancellationToken cancellationToken = default);
}
