// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
using System.IO;
using UnrealBuildTool;

public class TopDown1 : ModuleRules
{
	public TopDown1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule",
			"Json",
			"JsonUtilities",
			"Http"
			});

		// �������� sqlite3.dll � ����� Binary
		RuntimeDependencies.Add("$(BinaryOutputDir)/sqlite3.dll", Path.Combine(ModuleDirectory, "sqlite", "bin", "sqlite3.dll"));

		// ��������� ���������
		PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "sqlite", "bin", "sqlite3.lib"));

		// �������� �� �������� ���������
		PublicDelayLoadDLLs.Add("sqlite3.dll");
		


	}
}
