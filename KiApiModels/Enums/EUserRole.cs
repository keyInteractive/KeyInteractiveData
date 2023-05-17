using System.ComponentModel;

namespace KiApiModels.Enums;

public enum EUserRole
{
    /// <summary>
    /// Guest
    /// </summary>
    [Description("Guest")]
    Guest = 0,

    /// <summary>
    /// User
    /// </summary>
    [Description("User")]
    User = 1,

    /// <summary>
    /// Viewer
    /// </summary>
    [Description("Viewer")]
    Viewer = 2,

    /// <summary>
    /// Contributor
    /// </summary>
    [Description("Contributor")]
    Contributor = 3,

    /// <summary>
    /// Editor
    /// </summary>
    [Description("Editor")]
    Editor = 4,

    /// <summary>
    /// Admin
    /// </summary>
    [Description("Admin")]
    Admin = 5,

    /// <summary>
    /// Owner
    /// </summary>
    [Description("Owner")]
    Owner = 6,
}
