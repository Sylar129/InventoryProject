// Copyright Sylar129

using UnrealBuildTool;
using System.Collections.Generic;

public class InventoryProjectTarget : TargetRules
{
	public InventoryProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "InventoryProject" } );
	}
}
