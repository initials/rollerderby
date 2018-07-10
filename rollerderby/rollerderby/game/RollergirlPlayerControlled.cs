﻿/*
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
    class RollergirlPlayerControlled : Rollergirl
    {

        private bool _hasTransitioned;

        public RollergirlPlayerControlled(int xPos, int yPos)
            : base(xPos, yPos)
        {
            setDrags(225, 225);
            maxVelocity.Y = maxVelocity.X = 240;

            facing = Flx2DFacing.Right;

            

            _hasTransitioned = false;

        }

        /// <summary>
        /// The Update Cycle. Called once every cycle.
        /// </summary>
        override public void update()
        {
            //if (_hasTransitioned)
            //    color = Color.Green;
            //else
            //    color = Color.Red;

            if (FlxControl.ACTIONJUSTPRESSED)
            {
                velocity.X += 90;
            }
            if (FlxControl.CANCELJUSTPRESSED)
            {
                transition();
            }


            int movementValue = 8;

            if (FlxControl.UP)
            {
                velocity.Y -= movementValue;
            }
            if (FlxControl.DOWN)
            {
                velocity.Y += movementValue;
            }
            if (FlxControl.LEFT)
            {
                if (facing == Flx2DFacing.Right && _hasTransitioned)
                {

                }
                else
                {
                    facing = Flx2DFacing.Left;
                    _hasTransitioned = false;

                }
                
                velocity.X -= movementValue;
            }

            if (FlxControl.RIGHT)
            {
                if (facing == Flx2DFacing.Left && _hasTransitioned)
                {

                }
                else
                {
                    facing = Flx2DFacing.Right;
                    _hasTransitioned = false;

                }

                velocity.X += movementValue;
            }

            base.update();
        }

        private void transition()
        {
            //Console.WriteLine(facing);
            _hasTransitioned = true;


            if (facing==Flx2DFacing.Left)
                facing = Flx2DFacing.Right;
            else if (facing == Flx2DFacing.Right)
                facing = Flx2DFacing.Left;
        }

        /// <summary>
        /// The render code. Add any additional render code here.
        /// </summary>
        /// <param name="spriteBatch"></param>
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