﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OneButtonGame
{
    abstract class GameObject
    {
        public Vector2 Position { get; set; }

        // ON SPRITESHEET ALBIN MIN GODA KAMRAT OCH VÄN
        public Point SpritePosition { get; set; }
        public Point SourceSpriteSize { get; set; }

        public Point SpriteSize { get; set; }

        public Color SpriteColor { get; set; }

        public Rectangle Hitbox
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, SpriteSize.X, SpriteSize.Y); }
        }

        public float GetDistance(Vector2 target)
        {
            return (float)Math.Sqrt((Position.X - target.X) * (Position.X - target.X) + (Position.Y - target.Y) * (Position.X - target.Y));
        }

        public virtual void Update() { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.SpriteSheet, Hitbox, AssetManager.SpriteSheetSourceRect(new Point(0,0), new Point(SourceSpriteSize.X, SourceSpriteSize.Y)), SpriteColor);
        }
    }
}
