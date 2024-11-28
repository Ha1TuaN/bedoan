using System.Collections.ObjectModel;

namespace TD.KCN.WebApi.Shared.Authorization;
public static class TDSection
{
    public const string Tenants = nameof(Tenants);

    public const string System = "Hệ thống";
    public const string Categories = "Danh mục chung";
    public const string House = "Danh mục chung";

}

public static class TDAction
{
    public const string View = nameof(View);
    public const string Search = nameof(Search);
    public const string Create = nameof(Create);
    public const string Update = nameof(Update);
    public const string Delete = nameof(Delete);
    public const string Export = nameof(Export);
    public const string Generate = nameof(Generate);
    public const string Clean = nameof(Clean);
    public const string UpgradeSubscription = nameof(UpgradeSubscription);
    public const string Manage = nameof(Manage);
}

public static class TDResource
{
    #region Catalogs
    public const string Tenants = nameof(Tenants);
    public const string Dashboard = nameof(Dashboard);
    public const string Hangfire = nameof(Hangfire);
    public const string Categories = nameof(Categories);
    public const string OrganizationUnits = nameof(OrganizationUnits);
    public const string OrganizationUnitUsers = nameof(OrganizationUnitUsers);
    public const string Users = nameof(Users);
    public const string UserRoles = nameof(UserRoles);
    public const string Roles = nameof(Roles);
    public const string RoleClaims = nameof(RoleClaims);
    public const string Histories = nameof(Histories);
    public const string Areas = nameof(Areas);

    #endregion
    #region House
    public const string Motels = nameof(Motels);
    public const string FeatureHouses = nameof(FeatureHouses);
    public const string ImageHouses = nameof(ImageHouses);
    public const string Customers = nameof(Customers);


    #endregion
}

public static class TDPermissions
{
    private static readonly TDPermission[] _all =
    [
        new("Quản trị khu công nghiệp", TDAction.Manage, TDResource.Motels, TDSection.House, true),
    ];

    public static IReadOnlyList<TDPermission> All { get; } = new ReadOnlyCollection<TDPermission>(_all);
    public static IReadOnlyList<TDPermission> Root { get; } = new ReadOnlyCollection<TDPermission>(_all.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<TDPermission> Admin { get; } = new ReadOnlyCollection<TDPermission>(_all.Where(p => !p.IsRoot).ToArray());
}

public record TDPermission(
    string Description,
    string Action,
    string Resource,
    string Section,
    bool IsBasic = false,
    bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
}


