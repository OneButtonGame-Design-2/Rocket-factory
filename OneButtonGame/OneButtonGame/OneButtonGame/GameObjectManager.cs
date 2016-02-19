using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OneButtonGame
{
    class GameObjectManager
    {
        public List<GameObject> gameObjects;
        private List<GameObject> gameObjectsToAdd;
        private List<GameObject> gameObjectsToRemove;

        public GameObjectManager()
        {
            gameObjects = new List<GameObject>();
            gameObjectsToAdd = new List<GameObject>();
            gameObjectsToRemove = new List<GameObject>();
        }

        public void Update()
        {
            foreach (GameObject g in gameObjects)
            {
                g.Update();
            }

            foreach(GameObject g in gameObjectsToAdd) 
            {
                gameObjects.Add(g);
            }
            gameObjectsToAdd.Clear();

            foreach (GameObject g in gameObjectsToRemove)
            {
                gameObjects.Remove(g);
            }
            gameObjectsToRemove.Clear();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject g in gameObjects)
            {
                g.Draw(spriteBatch);
            }
        }

        public void Add(GameObject g)
        {
            gameObjectsToAdd.Add(g);
        }

        public void Remove(GameObject g)
        {
            gameObjectsToRemove.Add(g);
        }
    }
}
