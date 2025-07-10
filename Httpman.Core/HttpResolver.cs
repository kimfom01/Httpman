using System.Net.Http.Json;

namespace Httpman.Core;

public class HttpResolver : IHttpResolver
{
    public async Task<Result> MakeRequest(string urlString, object? body, RequestType requestType, CancellationToken cancellationToken = default)
    {
        switch (requestType)
        {
            case RequestType.GET:
                return await MakeGetRequest(urlString);
            case RequestType.POST:
                return await MakePostRequest(urlString, body);
            case RequestType.PUT:
                return await MakePutRequest(urlString, body);
            case RequestType.DELETE:
                return await MakeDeleteRequest(urlString, body);
            default:
                throw new ArgumentException();
        }
    }

    private async Task<Result> MakeGetRequest(string urlString)
    {
        using var httpClient = new HttpClient();

        var response = await httpClient.GetAsync(urlString);

        var result = new Result
        {
            StatusCode = (int)response.StatusCode
        };

        if (result.StatusCode is >= 200 and <= 299)
        {
            result.Body = await response.Content.ReadAsStringAsync();
        }

        return result;
    }

    private async Task<Result> MakePostRequest(string urlString, object? body)
    {
        var content = JsonContent.Create(body);

        using var httpClient = new HttpClient();

        var response = await httpClient.PostAsync(urlString, content);

        var result = new Result
        {
            StatusCode = (int)response.StatusCode
        };

        if (result.StatusCode is >= 200 and <= 299)
        {
            result.Body = await response.Content.ReadAsStringAsync();
        }

        return result;
    }

    private async Task<Result> MakePutRequest(string urlString, object? body)
    {
        var content = JsonContent.Create(body);

        using var httpClient = new HttpClient();

        var response = await httpClient.PutAsync(urlString, content);

        var result = new Result
        {
            StatusCode = (int)response.StatusCode
        };

        if (result.StatusCode is >= 200 and <= 299)
        {
            result.Body = await response.Content.ReadAsStringAsync();
        }

        return result;
    }

    private async Task<Result> MakeDeleteRequest(string urlString, object? body)
    {
        var content = JsonContent.Create(body);

        using var httpClient = new HttpClient();

        var response = await httpClient.DeleteAsync(urlString);

        var result = new Result
        {
            StatusCode = (int)response.StatusCode
        };

        if (result.StatusCode is >= 200 and <= 299)
        {
            result.Body = await response.Content.ReadAsStringAsync();
        }

        return result;
    }
}
