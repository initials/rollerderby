﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace RollerDerby
{
    /// <summary>
    /// FlxGlobals stores a bunch of constants
    /// </summary>
    public class Globals
    {


        /// <summary>
        /// putt_r to set the game to Roberto Selovino's
        /// </summary>
        public static string ContentFolder = "putt_r";

        public static string GameName
        {
            get
            {
                if (ContentFolder == "putt_r")
                {
                    return "Roberto Selavino's Putting Championship";
                }
                else
                {
                    return "Lee Carvallo's Putting Challenge";
                }
            }
        }

        public static string GolferName
        {
            get
            {
                if (ContentFolder == "putt_r")
                {
                    return "Roberto Selavino";
                }
                else
                {
                    return "Lee Carvallo";
                }
            }
        }

        public static string GameNameSplit
        {
            get
            {
                if (ContentFolder == "putt_r")
                {
                    return "Roberto Selavino's\nPutting Championship";
                }
                else
                {
                    return "Lee Carvallo's\nPutting Challenge";
                }
            }
        }

        /// <summary>
        /// Holes 1 - 18
        /// </summary>
        public static int hole = 1;

        /// <summary>
        /// PC, Touch,
        /// </summary>
        public static string platform = "PC";

        /// <summary>
        /// Can skip the audio.
        /// </summary>
        public static bool canSkip = false;

        /// <summary>
        /// Did it sink?
        /// </summary>
        public static bool ballInHole = false;

        public static bool pirate = false;

        /// <summary>
        /// Keeps score.
        /// </summary>
        public static List<int> scoreCard = new List<int> { };

        //public static Vector2 ballStartPosition = new Vector2(FlxG.width / 2 - 2, FlxG.height - 15);

        /// <summary>
        /// counts if hole takes more than one.
        /// </summary>
        public static bool hasPlayedHoleAgain = false;

        /// <summary>
        /// Allows the game to play through by itself.
        /// </summary>
        public static bool playThroughAutomatically = false;

        /// <summary>
        /// Includes Play Through Automatically.
        /// </summary>
        public static bool ACTIONJUSTPRESSED
        {
            get
            {
                return playThroughAutomatically ||
                    FlxG.keys.justPressed(Keys.N) ||
                    FlxG.keys.justPressed(Keys.X) ||
                    FlxG.keys.justPressed(Keys.Enter) ||
                    FlxG.keys.justPressed(Keys.Space) ||
                    FlxG.gamepads.isNewButtonPress(Buttons.A) ||
                    FlxG.gamepads.isNewButtonPress(Buttons.Start);
                //|| (FlxG.mouse.justPressed() && FlxG.mouse.x > (FlxG.width / 4) * 3)
            }
        }

    }
}
