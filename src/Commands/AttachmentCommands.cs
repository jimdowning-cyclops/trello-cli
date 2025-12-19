using TrelloCli.Models;
using TrelloCli.Services;
using TrelloCli.Utils;

namespace TrelloCli.Commands;

public class AttachmentCommands
{
    private readonly TrelloApiService _api;

    public AttachmentCommands(TrelloApiService api)
    {
        _api = api;
    }

    public async Task GetAttachmentsAsync(string cardId)
    {
        if (string.IsNullOrEmpty(cardId))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("Card ID required", "MISSING_PARAM"));
            return;
        }

        var result = await _api.GetAttachmentsAsync(cardId);
        OutputFormatter.Print(result);
    }

    public async Task UploadAttachmentAsync(string cardId, string filePath, string? name = null)
    {
        if (string.IsNullOrEmpty(cardId))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("Card ID required", "MISSING_PARAM"));
            return;
        }

        if (string.IsNullOrEmpty(filePath))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("File path required", "MISSING_PARAM"));
            return;
        }

        var result = await _api.UploadAttachmentAsync(cardId, filePath, name);
        OutputFormatter.Print(result);
    }

    public async Task AttachUrlAsync(string cardId, string url, string? name = null)
    {
        if (string.IsNullOrEmpty(cardId))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("Card ID required", "MISSING_PARAM"));
            return;
        }

        if (string.IsNullOrEmpty(url))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("URL required", "MISSING_PARAM"));
            return;
        }

        var result = await _api.AttachUrlAsync(cardId, url, name);
        OutputFormatter.Print(result);
    }

    public async Task DeleteAttachmentAsync(string cardId, string attachmentId)
    {
        if (string.IsNullOrEmpty(cardId))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("Card ID required", "MISSING_PARAM"));
            return;
        }

        if (string.IsNullOrEmpty(attachmentId))
        {
            OutputFormatter.Print(ApiResponse<object>.Fail("Attachment ID required", "MISSING_PARAM"));
            return;
        }

        var result = await _api.DeleteAttachmentAsync(cardId, attachmentId);
        OutputFormatter.Print(result);
    }
}
