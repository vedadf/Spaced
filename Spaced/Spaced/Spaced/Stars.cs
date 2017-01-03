﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Spaced
{
    class Stars
    {

        Texture2D texture;
        //may need to change to function
        public Vector2 position;
        Vector2 velocity;

        public Stars(Texture2D newTexture, Vector2 newPosition, Vector2 newVelocity)
        {
            texture = newTexture;
            position = newPosition;
            velocity = newVelocity;
        }

        public void Update()
        {
            position += velocity;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}