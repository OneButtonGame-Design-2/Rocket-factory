using System;
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

        public Point SpritePosition { get; set; }
        public Point SpriteSize { get; set; }

        public Point SpriteScale { get; set; }

        public virtual void Update() { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
