using System.Collections.ObjectModel;

namespace TD.KCN.WebApi.Shared.Authorization;

public static class TDRoles
{
    public const string Admin = "Admin";
    public const string Basic = "Basic";

    public static IReadOnlyList<string> DefaultRoles { get; } =
        new ReadOnlyCollection<string>([
            Admin,
            Basic,
        ]);

    public static bool IsDefault(string roleName) =>
        DefaultRoles.Any(r => r == roleName);
}