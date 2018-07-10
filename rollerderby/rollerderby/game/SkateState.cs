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
    public class SkateState : FlxState
    {

        private Rollergirl rg;

        override public void create()
        {
            FlxG.backColor = Color.Purple;
            base.create();

            Grid g = new Grid(0, 0);
            add(g);

            rg = new Rollergirl(30, 50);
            add(rg);

            FlxG.follow(rg, 5.0f);
            FlxG.followBounds(0, 0, 10000, 10000);

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
