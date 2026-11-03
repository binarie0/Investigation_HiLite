// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Enhanced_Vision_Lite : ModuleRules
{
	public Enhanced_Vision_Lite(ReadOnlyTargetRules Target) : base(Target)
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
			"Enhanced_Vision_Lite",
			"Enhanced_Vision_Lite/Variant_Platforming",
			"Enhanced_Vision_Lite/Variant_Platforming/Animation",
			"Enhanced_Vision_Lite/Variant_Combat",
			"Enhanced_Vision_Lite/Variant_Combat/AI",
			"Enhanced_Vision_Lite/Variant_Combat/Animation",
			"Enhanced_Vision_Lite/Variant_Combat/Gameplay",
			"Enhanced_Vision_Lite/Variant_Combat/Interfaces",
			"Enhanced_Vision_Lite/Variant_Combat/UI",
			"Enhanced_Vision_Lite/Variant_SideScrolling",
			"Enhanced_Vision_Lite/Variant_SideScrolling/AI",
			"Enhanced_Vision_Lite/Variant_SideScrolling/Gameplay",
			"Enhanced_Vision_Lite/Variant_SideScrolling/Interfaces",
			"Enhanced_Vision_Lite/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
