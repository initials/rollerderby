using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;

using System.Linq;
using System.Xml.Linq;

namespace RollerDerby
{
    public class IntroState : FlxState
    {

        override public void create()
        {
            FlxG.backColor = Color.Purple;
            base.create();

            for (int i = 0; i < 10; i++)
            {
                Rollergirl spr = new Rollergirl(10 + i, 33 + (i * 20));
                add(spr);
                spr.velocity.X = FlxU.random(55, 120);
            }

            RollergirlPlayerControlled r = new RollergirlPlayerControlled(10, 55);
            add(r);


        }

        override public void update()
        {

            base.update();
        }

        public override void render(SpriteBatch spriteBatch)
        {
            
            base.render(spriteBatch);
        }


    }
}
