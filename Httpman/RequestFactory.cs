using Httpman.Core;

namespace Httpman;

internal static class RequestFactory
{
    public static IHttpResolver GetHttpResolver()
    {
        return new HttpResolver();
    }
}
