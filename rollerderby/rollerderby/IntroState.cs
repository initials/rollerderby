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

            for (int i = 0; i < 10; i++)
            {
                rg = new Rollergirl(10 + i, 33 + (i * 30));
                rollergirls.add(rg);

                rg.velocity.X = FlxU.random(45, 55);
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

            base.update();
        }

        public override void render(SpriteBatch spriteBatch)
        {

            base.render(spriteBatch);

        }
    }
}
