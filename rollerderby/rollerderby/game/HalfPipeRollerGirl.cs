
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
    class HalfPipeRollerGirl : FlxSprite
    {
        private PushDirection currentPushDirection;
        private Status currentStatus;
        private FlxPath path;

        private const int SPEED = 125;

        public enum PushDirection
        {
            Left = 0,
            Right = 1,
            None = 2
        }

        public enum Status
        {
            Ready = 0,
            LeftUpwards=1,
            LeftDownwards = 2,
            FlatMovingLeft = 3,
            RightTransition = 4,
            RightUpwards = 5,
            RightDownwards =6,
            FlatMovingRight=7
        }

        public HalfPipeRollerGirl(int xPos, int yPos)
            : base(xPos, yPos)
        {
            loadGraphic("rollerskatergirl/rollergirl_cali", true, false, 64, 64);


            facing = Flx2DFacing.Right;

            width = 12;
            offset.X = 26;
            //height = 32;

            addAnimation("idle", new int[] { 0 }, 12, true);

            addAnimation("skate", new int[] { 0, 1, 2, 2, 2, 0, 3, 4, 4, 4 }, FlxU.randomInt(4, 10), true);

            addAnimation("pushLeft", new int[] { 0, 3, 4, 4, 4 }, FlxU.randomInt(6, 9), false);
            addAnimation("pushRight", new int[] { 0, 1, 2, 2, 2 }, FlxU.randomInt(6, 9), false);

            addAnimation("spin", new int[] { 13, 14, 15, 16, 0 }, 12, false);
            addAnimation("jump", new int[] { 17, 18, 19, 20 }, 24, false);

            play("skate", true);

            this.currentPushDirection = PushDirection.None;
            this.currentStatus = Status.FlatMovingRight;

            //drag.X = 25;
            //drag.Y = 25;

            acceleration.Y = 980;

            //path = new FlxPath(null);
            //path.add(30, 30);
            //path.add(30, 140);
            //path.add(180, 140);
            //path.add(180, 30);

            //followPath(path, 250, FlxSprite.PATH_LOOP_FORWARD, false);
            //startFollowingPath();
            velocity.X = SPEED;
        }

        override public void update()
        {

            // limits 30, 180;

            //reached the right limit
            //if (x > 180)
            //{
            //    facing = Flx2DFacing.Left;
            //    x = 179;
            //    velocity.X = -75;
            //}

            //if (x < 30)
            //{
            //    facing = Flx2DFacing.Right;
            //    x = 31;
            //    velocity.X = 75;
            //}

            if (FlxG.keys.justPressed(Keys.A))
            {
                facing = Flx2DFacing.Left;

            }
            if (FlxG.keys.justPressed(Keys.D))
            {
                facing = Flx2DFacing.Right;
            }
            if (y < 100 && FlxG.keys.W)
            {
                play("spin");
            }
            else if (y < 100)
            {
                play("jump");
            }
             
            else
            {
                play("skate");
            }

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
            if (velocity.Y > 0)
            {
                facing = Flx2DFacing.Right;
                velocity.X = SPEED;
            }

        }

        /// <summary>
        /// Called when the sprite hits something on its right side
        /// </summary>
        /// <param name="Contact"></param>
        /// <param name="Velocity"></param>
        public override void hitRight(FlxObject Contact, float Velocity)
        {
            base.hitRight(Contact, Velocity);

            if (velocity.Y > 0)
            {
                facing = Flx2DFacing.Left;
                velocity.X = SPEED * -1;
            }

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

        public override void overlapped(FlxObject obj)
        {
            base.overlapped(obj);

            if (((LaunchBlock)(obj)).direction == this.facing)
            {
                velocity.Y -= 45;
            }
            else
            {
                if (x < 120)
                    velocity.X = SPEED;
                else
                    velocity.X = SPEED * -1;
            }
        }
    }
}
