using System;

internal static class PermissionBuilder
{
    public static Permissions FromName(string permissionName)
    {
        return permissionName switch
        {
            "Default" => Permissions.Default,
            "UserRead" => Permissions.UserRead,
            "UserWrite" => Permissions.UserWrite,
            "UserExecute" => Permissions.UserExecute,
            "GroupRead" => Permissions.GroupRead,
            "GroupWrite" => Permissions.GroupWrite,
            "GroupExecute" => Permissions.GroupExecute,
            "EveryoneRead" => Permissions.EveryoneRead,
            "EveryoneWrite" => Permissions.EveryoneWrite,
            "EveryoneExecute" => Permissions.EveryoneExecute,
            _ => throw new NotImplementedException()
        };
    }
}