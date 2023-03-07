namespace OpenFga.Sdk.Client.Model;

public class ClientCheckOptions : IClientRequestOptionsWithAuthZModelId {
    /// <inheritdoc />
    public RetryParams? RetryParams { get; set; }

    /// <inheritdoc />
    public Dictionary<string, string>? Headers { get; set; }

    /// <inheritdoc />
    public string? AuthorizationModelId { get; set; }
}