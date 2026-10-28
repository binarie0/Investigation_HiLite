// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Investigation_HiLite : ModuleRules
{
	public Investigation_HiLite(ReadOnlyTargetRules Target) : base(Target)
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
			"Investigation_HiLite",
			"Investigation_HiLite/Variant_Platforming",
			"Investigation_HiLite/Variant_Platforming/Animation",
			"Investigation_HiLite/Variant_Combat",
			"Investigation_HiLite/Variant_Combat/AI",
			"Investigation_HiLite/Variant_Combat/Animation",
			"Investigation_HiLite/Variant_Combat/Gameplay",
			"Investigation_HiLite/Variant_Combat/Interfaces",
			"Investigation_HiLite/Variant_Combat/UI",
			"Investigation_HiLite/Variant_SideScrolling",
			"Investigation_HiLite/Variant_SideScrolling/AI",
			"Investigation_HiLite/Variant_SideScrolling/Gameplay",
			"Investigation_HiLite/Variant_SideScrolling/Interfaces",
			"Investigation_HiLite/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
