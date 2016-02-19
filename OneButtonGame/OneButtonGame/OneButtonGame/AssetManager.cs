using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OneButtonGame
{
    public class AssetManager
    {
        public static Texture2D SpriteSheet { get; set; }

        private static int CellSize { get; set; }

        public static void Load(ContentManager contentManager)
        {
            SpriteSheet = contentManager.Load<Texture2D>("SpriteSheet");
            CellSize = 60;
        }

        public static Rectangle SpriteSheetSourceRect(Point gridPosition, Point size)
        {
            return new Rectangle(gridPosition.X * CellSize, gridPosition.Y * CellSize, size.X, size.Y);
        }
    }
}
