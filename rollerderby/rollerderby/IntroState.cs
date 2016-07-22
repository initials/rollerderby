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

            //FlxSprite testPattern = new FlxSprite(0, 0);
            //testPattern.loadGraphic("flixel/diagnostic/checkerboard");
            //add(testPattern);

            //Logo logo = new Logo(0, 0);
            //add(logo);



            for (int i = 0; i < 10; i++)
            {
                FlxSprite spr = new FlxSprite(10 + i, 33+(i*20));
                spr.loadGraphic("rollerskatergirl/rollergirl");
                add(spr);
                spr.velocity.X = FlxU.random(20, 120);
            }




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
