// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class lab3 : ModuleRules
{
	public lab3(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"lab3",
			"lab3/Variant_Platforming",
			"lab3/Variant_Platforming/Animation",
			"lab3/Variant_Combat",
			"lab3/Variant_Combat/AI",
			"lab3/Variant_Combat/Animation",
			"lab3/Variant_Combat/Gameplay",
			"lab3/Variant_Combat/Interfaces",
			"lab3/Variant_Combat/UI",
			"lab3/Variant_SideScrolling",
			"lab3/Variant_SideScrolling/AI",
			"lab3/Variant_SideScrolling/Gameplay",
			"lab3/Variant_SideScrolling/Interfaces",
			"lab3/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
