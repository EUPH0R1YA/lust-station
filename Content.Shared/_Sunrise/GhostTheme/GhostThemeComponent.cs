using Robust.Shared.GameStates;

namespace Content.Shared._Sunrise.GhostTheme;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]

public sealed partial class GhostThemeComponent: Component
{
    [DataField, AutoNetworkedField]
    public string? GhostTheme;
}