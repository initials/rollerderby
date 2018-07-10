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
        private RollergirlsGroup rollergirls;
        private Rollergirl rg;


        override public void create()
        {
            FlxG.backColor = Color.Purple;
            base.create();

            rollergirls = new RollergirlsGroup();


            Grid g = new Grid(0, 0);
            add(g);

            for (int i = 0; i < 30; i++)
            {
                rg = new Rollergirl(10 + i, 33 + (i * 15));
                rollergirls.add(rg);

                rg.velocity.X = FlxU.random(35, 75);
                rg.velocity.Y = FlxU.random(-15, 15);

            }

            RollergirlPlayerControlled r = new RollergirlPlayerControlled(10, 55);
            rollergirls.add(r);

            FlxG.follow(r, 5.0f);
            FlxG.followBounds(0, 0, 10000, 10000);

            add(rollergirls);




        }

        override public void update()
        {
            //rollergirls.update();

            if (FlxG.keys.justPressed(Keys.B))
            {
                FlxG.showBounds = true;
            }

            base.update();
        }

        public override void render(SpriteBatch spriteBatch)
        {

            base.render(spriteBatch);

        }
    }
}
