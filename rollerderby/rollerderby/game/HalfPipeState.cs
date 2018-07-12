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
    public class HalfPipeState : FlxState
    {

        private HalfPipeRollerGirl rg;

        private FlxGroup collisionBlocks;

        private FlxGroup launchBlocks;

        override public void create()
        {
            FlxG.backColor = Color.Purple;
            base.create();

            Bg bg = new Bg(0, 0);
            add(bg);

            rg = new HalfPipeRollerGirl(29, 140);
            add(rg);

            //FlxG.follow(rg, 5.0f);
            //FlxG.followBounds(0, 0, 10000, 10000);

            collisionBlocks = new FlxGroup();
            add(collisionBlocks);

            CollisionBlock c = new CollisionBlock(20, 0);
            c.width = 30;
            c.height = 200;
            collisionBlocks.add(c);

            c = new CollisionBlock(210, 0);
            c.width = 30;
            c.height = 200;
            collisionBlocks.add(c);

            c = new CollisionBlock(20, 200);
            c.width = 200;
            c.height = 30;
            collisionBlocks.add(c);

            launchBlocks = new FlxGroup();
            add(launchBlocks);

            LaunchBlock l = new LaunchBlock(50, 170);
            l.direction = Flx2DFacing.Left;
            launchBlocks.add(l);

            l = new LaunchBlock(180, 170);
            l.direction = Flx2DFacing.Right;
            launchBlocks.add(l);

        }

        override public void update()
        {
            //rollergirls.update();

            if (FlxG.keys.justPressed(Keys.B))
            {
                FlxG.showBounds = true;
            }

            FlxU.collide(rg, collisionBlocks);

            FlxU.overlap(rg, launchBlocks, overlapped);

            base.update();
        }

        public override void render(SpriteBatch spriteBatch)
        {

            base.render(spriteBatch);

        }
        protected bool overlapped(object Sender, FlxSpriteCollisionEvent e)
        {
            ((HalfPipeRollerGirl)(e.Object1)).overlapped(e.Object2);
            return true;
        }

    }
}
