using System.Reflection;
using UnityEngine;
namespace ShipEffectsContinued
{
    // http://forum.kerbalspaceprogram.com/index.php?/topic/147576-modders-notes-for-ksp-12/#comment-2754813
    // search for "Mod integration into Stock Settings
    // HighLogic.CurrentGame.Parameters.CustomParams<SE>().

    public class SE : GameParameters.CustomParameterNode
    {
        public override string Title { get { return ""; } }
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override string Section { get { return "Ship Effects"; } }
        public override string DisplaySection { get { return "Ship Effects"; } }
        public override int SectionOrder { get { return 1; } }
        public override bool HasPresets { get { return false; } }

        [GameParameters.CustomParameterUI("Only in IVA")]
        public bool OnlyInIVA = true;

        [GameParameters.CustomParameterUI("Only if crewed")]
        public bool OnlyIfCrewed = true;

        [GameParameters.CustomFloatParameterUI("Master Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float masterVolume = 100.0f;

        [GameParameters.CustomFloatParameterUI("Rattle Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float rattleVolume = 100.0f;

        [GameParameters.CustomFloatParameterUI("Vibration Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float vibrationVolume = 100.0f;

        [GameParameters.CustomFloatParameterUI("Rumble Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float rumbleVolume = 100.0f;

        [GameParameters.CustomFloatParameterUI("Thump Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float thumpVolume = 100.0f;

        [GameParameters.CustomFloatParameterUI("Stress Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float stressVolume = 60.0f;

        [GameParameters.CustomFloatParameterUI("Atmosphere Volume", minValue = 0, maxValue = 100f, stepCount = 101, displayFormat = "F0",
                toolTip = "range is from 0-100")]
        public float atmosphereVolume = 60.0f;

        [GameParameters.CustomFloatParameterUI("Resist Multiplier", minValue = 0.1f, maxValue = 5f, stepCount = 101, displayFormat = "F2",
                toolTip = "Exaggerates or eases the value that controls the sound. a higher number means Sounds will play sooner, lower means later.")]
        public float resistMultiplier = 1.75f;

        // Default is 8.0, how much g-force to simulate during re-entry
        [GameParameters.CustomFloatParameterUI("ReEntry Multiplier", minValue = 2, maxValue = 16f, stepCount = 101, displayFormat = "F1",
                toolTip = "How much g-force to simulate during re-entry. range is from 0-100")]
        public float reEntryMultiplier = 8.0f;


        public override void SetDifficultyPreset(GameParameters.Preset preset)
        {
        }

        public override bool Enabled(MemberInfo member, GameParameters parameters)
        {
            return true;
        }
        public override bool Interactible(MemberInfo member, GameParameters parameters)
        {
            return true;
        }


    }
}
