// Copyright (c) 2018 David Nadaski. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CoverDemoTarget : TargetRules
{
	public CoverDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "CoverDemo" } );
	}
}
