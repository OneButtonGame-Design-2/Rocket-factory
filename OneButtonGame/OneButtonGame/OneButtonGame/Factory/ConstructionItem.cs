using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace OneButtonGame.Factory
{
    class ConstructionItem : GameObject
    {
        const float DISTANCE_TO_HIT = 16;

        private enum State { NOT_READY, READY };

        private float speed;
        private float worth;
        private float angle;

        private Vector2 endPoint;

        private State state;

        public ConstructionItem(Vector2 position, Vector2 endPoint)
        {
            this.Position = position;
            this.endPoint = endPoint;

            worth = 100;
        }

        public override void Update()
        {
            if (state != State.NOT_READY)
            {
                foreach (Player p in Game1.gameObjectManger.gameObjects.Where(item => item is Player))
                {
                    if (GetDistance(p.Position) <= DISTANCE_TO_HIT)
                    {
                        if (p.hasHit)
                        {
                            state = State.READY;
                            p.Score += worth - (GetDistance(p.Position) / DISTANCE_TO_HIT) * 1000;
                        }
                    }
                }
            }

            Position += Velocity;

            base.Update();
        }

        public Vector2 Velocity
        {
            get { return new Vector2((float)Math.Cos(angle) * speed, (float)Math.Sin(angle) * speed); }
        }
    }
}
