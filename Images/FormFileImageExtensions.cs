using Microsoft.AspNetCore.Http;

namespace Lib.Images;

public static class FormFileImageExtensions
{
    public static async Task<string> ToBase64Async(this IFormFile file)
    {
        await using var ms = new MemoryStream();
        await file.CopyToAsync(ms);
        return Convert.ToBase64String(ms.ToArray());
    }
}
