using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace OneButtonGame
{
    class Rocket : GameObject
    {
        public Vector2 Velocity { get; set; }
        public Vector2 TargetVelocity { get; set; }

        public int TotalTime { get; private set; }
        public int NextBoostTime { get; private set; }
        public int TimeBetweenBoosts { get { return 80; } }

        private float standardAcceleration = .2f;
        private float boostAcceleration;

        

        public Rocket()
        {
            
        }

        public override void Update()
        {
            base.Update();
            TotalTime++;

            this.Velocity = Vector2.Lerp(Velocity, TargetVelocity, boostAcceleration);
            TargetVelocity *= .98f;
            boostAcceleration = MathHelper.Lerp(boostAcceleration, standardAcceleration, .1f);

            if (Input.IsKeyDown(Keys.Space))
            {
                Boost();
            }
        }

        void Boost()
        {
            if (TotalTime > NextBoostTime)
            {
                TargetVelocity = new Vector2(0, -25);
                boostAcceleration = .85f;

                NextBoostTime = TotalTime + TimeBetweenBoosts;
            }
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.SpriteSheet, AssetManager.SpriteSheetSourceRect(new Point(0, 0), new Point(256, 256)), Color.White);
        }

    }
}
