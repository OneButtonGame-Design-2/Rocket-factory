using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace OneButtonGame
{
    public static class Input
    {
        public static KeyboardState KeyboardState { get; set; }
        public static KeyboardState PrevKeyboardState { get; set; }

        public static bool IsKeyDown(Keys key)
        {
            PrevKeyboardState = KeyboardState;
            KeyboardState = Keyboard.GetState();

            return KeyboardState.IsKeyDown(key);
        }

        public static bool IsKeyDownContinually(Keys key)
        {
            PrevKeyboardState = KeyboardState;
            KeyboardState = Keyboard.GetState();

            return KeyboardState.IsKeyDown(key) && PrevKeyboardState.IsKeyUp(key);
        }

    }
}
