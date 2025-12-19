using System.Text.Json.Serialization;

namespace TrelloCli.Models;

public class Comment
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    [JsonPropertyName("data")]
    public CommentData Data { get; set; } = new();

    [JsonPropertyName("memberCreator")]
    public CommentMember MemberCreator { get; set; } = new();
}

public class CommentData
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
}

public class CommentMember
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("fullName")]
    public string FullName { get; set; } = string.Empty;

    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;
}
