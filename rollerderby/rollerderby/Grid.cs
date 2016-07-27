/*
 * Add these to Visual Studio to quickly create new FlxSprites
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace RollerDerby
{
    class Grid : FlxSprite
    {

        public Grid(int xPos, int yPos)
            : base(xPos, yPos)
        {
            
        }

        /// <summary>
        /// The Update Cycle. Called once every cycle.
        /// </summary>
        override public void update()
        {
            base.update();
        }

        /// <summary>
        /// The render code. Add any additional render code here.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public override void render(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < 20; i++)
            {
                FlxLine l = new FlxLine(0, 0, new Vector2(0 + (i * 100), 0), new Vector2(500 + (i * 100), 1000), Color.White, 1);
                l.render(spriteBatch);

                FlxLine lr = new FlxLine(0, 0, new Vector2(0, 120 + (i * 50)), new Vector2(10000, 120 + (i * 50)), Color.White, 1);
                lr.render(spriteBatch);


            }


            base.render(spriteBatch);
        }

       
    }
}
