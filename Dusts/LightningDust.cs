using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Trinitarian.Dusts
{
	public class LightningDust : ModDust
	{
        public override bool MidUpdate(Dust dust)
        {
            if (!dust.noGravity)
            {
                dust.velocity.Y += 0.05f;
            }
            Lighting.AddLight(dust.position, 0.4f, 0.4f, 0.4f);
            return false;
        }
    }
}