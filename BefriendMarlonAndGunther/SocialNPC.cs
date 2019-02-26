using StardewValley;

namespace BefriendMarlonAndGunther
{
    /// <summary>Wraps an NPC to force it to be socialisable.</summary>
    public class SocialNPC : NPC
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The original NPC.</summary>
        public NPC OriginalNpc { get; }

        /// <summary>Where the NPC can socialize.</summary>
        public override bool CanSocialize { get; } = true;


        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="npc">The original NPC.</param>
        public SocialNPC(NPC npc)
            : base(npc.Sprite, npc.Position, npc.DefaultMap, npc.FacingDirection, npc.Name, npc.datable.Value, null, npc.Portrait)
        {
            this.OriginalNpc = npc;
        }
    }
}
