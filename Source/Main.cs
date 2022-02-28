using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using UnityEngine;
using Verse;
using Verse.AI;
using Verse.AI.Group;
using Verse.Sound;
using Verse.Noise;
using Verse.Grammar;
using RimWorld;
using RimWorld.Planet;

// using System.Reflection;
// using HarmonyLib;

namespace NoBitches
{
    public class ThoughtWorker_HasNoBitches : ThoughtWorker
	{
		protected override ThoughtState CurrentStateInternal(Pawn p) {
            if((LovePartnerRelationUtility.HasAnyLovePartner(p,false)) || (p?.story?.traits?.HasTrait(TraitDefOf.Asexual) ?? false)) {
                return ThoughtState.Inactive;
            }
            return ThoughtState.ActiveAtStage(0);
        }
	}
    [StaticConstructorOnStartup]
    public static class Start
    {
        static Start()
        {
            Log.Message("No Bitches loaded successfully!");
        }
    }

}
