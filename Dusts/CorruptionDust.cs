using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Trinitarian.Dusts
{
    public class CorruptionDust : ModDust
    {
        public override bool MidUpdate(Dust dust)
        {
            if (!dust.noGravity)
            {
                dust.velocity.Y += 0.05f;
            }
            Lighting.AddLight(dust.position, 0.2f, 0.2f, 0.2f);
            return false;
        }
    }
}