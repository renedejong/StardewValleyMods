using Microsoft.Xna.Framework;
using StardewValley;
using System;

namespace StardewValleyMods.LoveBubbles
{
    public static class Renderer
    {
        private static readonly TextureRegion Bubble = new TextureRegion(Game1.mouseCursors, new Rectangle(141, 465, 20, 24), zoom: true);

        private static readonly TextureRegion Heart = new TextureRegion(Game1.mouseCursors, new Rectangle(226, 1811, 13, 12), zoom: true);

        public static void DrawBubble(FarmAnimal animal)
        {
            if (animal == null)
            {
                return;
            }

            var bubblePosition = new Vector2(
                animal.Position.X + animal.Sprite.getWidth() / 2,
                animal.Position.Y - (Game1.tileSize * 4) / 3 + GetBubbleOffset());

            Game1.spriteBatch.Draw(Bubble,
                Game1.GlobalToLocal(Game1.viewport, bubblePosition),
                Color.White * 0.75f);

            var heartPosition = bubblePosition
                + new Vector2(Bubble.Width / 2, Bubble.Height / 2)
                - new Vector2(Heart.Width / 2, Heart.Height / 2)
                - new Vector2(0, 4);

            Game1.spriteBatch.Draw(Heart,
                Game1.GlobalToLocal(Game1.viewport, heartPosition),
                new Color(255, 128, 128, 192));
        }

        private static float GetBubbleOffset()
        {
            return (float)(4.0 * Math.Round(Math.Sin(DateTime.Now.TimeOfDay.TotalMilliseconds / 250.0), 2));
        }
    }
}
