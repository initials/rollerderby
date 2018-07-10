
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
    class Rollergirl : FlxSprite
    {
        private PushDirection currentPushDirection;

        public enum PushDirection
        {
            Left = 0,
            Right = 1,
            None = 2
        }

        public Rollergirl(int xPos, int yPos)
            : base(xPos, yPos)
        {
            loadGraphic("rollerskatergirl/cali", true, false, 64,64);

            
            facing = Flx2DFacing.Right;

            //width = 32;
            //height = 32;

            addAnimation("idle", new int[] { 0 }, 12, true);

            addAnimation("skate", new int[] { 0,1,2,2,2,0,3,4,4,4 }, FlxU.randomInt(4,10), true);

            addAnimation("pushLeft", new int[] { 0, 3, 4, 4, 4 }, FlxU.randomInt(6, 9), false);
            addAnimation("pushRight", new int[] { 0, 1, 2, 2, 2 }, FlxU.randomInt(6, 9), false);

            addAnimation("spin", new int[] { 13,14,15,16,0}, 12, false);
            addAnimation("jump", new int[] { 17,18,19,20 }, 24, false);

            play("idle", true);

            currentPushDirection = PushDirection.None;

            drag.X = 150;
            drag.Y = 150;

        }

        override public void update()
        {
            if (FlxG.keys.justPressed(Keys.A))
            {
                currentPushDirection = PushDirection.Left;
                this.velocity.X = 130 ;
                play("pushLeft", false);

            }
            if (FlxG.keys.justPressed(Keys.D))
            {
                currentPushDirection = PushDirection.Right;
                this.velocity.X = 130;
                play("pushRight", false);
            }
            if (FlxG.keys.justPressed(Keys.R))
            {
                play("spin", false);
            }
            if (FlxG.keys.justPressed(Keys.Space))
            {
                play("jump", false);
            }


            //if (currentPushDirection == PushDirection.Left)
            //{
            //    play("pushLeft", false);
            //}
            //if (currentPushDirection == PushDirection.Right)
            //{
            //    play("pushRight", false);
            //}
            //if (currentPushDirection == PushDirection.None)
            //{
            //    play("idle", false);
            //}


            base.update();
        }


        public override void render(SpriteBatch spriteBatch)
        {
            base.render(spriteBatch);
        }

        /// <summary>
        /// Called when the sprite hit something on its bottom edge.
        /// </summary>
        /// <param name="Contact">The Object that it collided with.</param>
        /// <param name="Velocity">The Velocity that is will now have???</param>
        public override void hitBottom(FlxObject Contact, float Velocity)
        {
            base.hitBottom(Contact, Velocity);
        }

        /// <summary>
        /// Called when the sprite hits something on its left side.
        /// </summary>
        /// <param name="Contact">The Object that it collided with.</param>
        /// <param name="Velocity"></param>
        public override void hitLeft(FlxObject Contact, float Velocity)
        {
            base.hitLeft(Contact, Velocity);
        }

        /// <summary>
        /// Called when the sprite hits something on its right side
        /// </summary>
        /// <param name="Contact"></param>
        /// <param name="Velocity"></param>
        public override void hitRight(FlxObject Contact, float Velocity)
        {
            base.hitRight(Contact, Velocity);
        }

        /// <summary>
        /// Called when the sprite hits something on its side, either left or right.
        /// </summary>
        /// <param name="Contact"></param>
        /// <param name="Velocity"></param>
        public override void hitSide(FlxObject Contact, float Velocity)
        {
            base.hitSide(Contact, Velocity);
        }

        /// <summary>
        /// Called when the sprite hits something on its top
        /// </summary>
        /// <param name="Contact"></param>
        /// <param name="Velocity"></param>
        public override void hitTop(FlxObject Contact, float Velocity)
        {
            base.hitTop(Contact, Velocity);
        }

        /// <summary>
        /// Used when the sprite is damaged or hurt. Takes points off "Health".
        /// </summary>
        /// <param name="Damage">Amount of damage to take away.</param>
        public override void hurt(float Damage)
        {
            base.hurt(Damage);
        }

        /// <summary>
        /// Kill the sprite.
        /// </summary>
        public override void kill()
        {
            base.kill();
        }
    }
}
