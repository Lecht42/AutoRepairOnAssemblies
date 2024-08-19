using RimWorld;
using Verse;

namespace AutoRepairOn
{
    internal class CompProperties_MechRepairableOn : CompProperties
    {
        public CompProperties_MechRepairableOn()
        {
            compClass = typeof(CompMechRepairableOn);
        }
    }

    internal class CompMechRepairableOn : CompMechRepairable
    {
        private new const bool autoRepair = true;

        public new CompProperties_MechRepairableOn Props => (CompProperties_MechRepairableOn)props;

        public CompMechRepairableOn() : base()
        {
            base.autoRepair = autoRepair;
        }
    }
}
