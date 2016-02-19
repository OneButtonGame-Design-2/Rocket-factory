using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using 

namespace OneButtonGame
{
    public class Rocket : GameObject
    {
        public Rocket()
        {
            
        }

        public override void Update(

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.SpriteSheet, AssetManager.SpriteSheetSourceRect(new Point(0, 0), new Point(256, 256)), Color.White);
        }

    }
}
