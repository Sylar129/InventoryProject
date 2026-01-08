// Copyright Sylar129

using UnrealBuildTool;
using System.Collections.Generic;

public class InventoryProjectEditorTarget : TargetRules
{
	public InventoryProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "InventoryProject" } );
	}
}
