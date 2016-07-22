#region File Description
//-----------------------------------------------------------------------------
// Flixel for XNA.
// Original repo : https://github.com/StAidan/X-flixel
// Extended and edited repo : https://github.com/initials/XNAMode
//-----------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.flixel;
using Microsoft.Xna.Framework;

namespace Loader_RollerDerby
{
    /// <summary>
    /// Flixel enters here.
    /// <code>FlxFactory</code> refers to it as the "masterclass".
    /// </summary>
    public class FlixelEntryPoint2 : FlxGame
    {
        public FlixelEntryPoint2(Game game)
            : base(game)
        {
            ///Post build zipper
            ///cd ..
            ///C:\_Files\programs\7-Zip\7z a -tzip FourChambers.zip Release\ -r

            int w = FlxG.resolutionWidth / FlxG.zoom;
            int h = FlxG.resolutionHeight / FlxG.zoom;

            //initGame(w, h, new Island.IntroState(), new Color(15, 15, 15), true, new Color(5, 5, 5));

            initGame(w, h, new RollerDerby.IntroState(), new Color(0, 0, 0), false, new Color(0, 0, 0));


            string buildType = "FULL";
            FlxG.debug = false;

#if DEBUG
            FlxG.debug = true;
#endif
#if PIRATE
            Globals.pirate=true;
#endif

            //Selavino.Globals.pirate = true;


            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"version.txt"))
            {
                file.WriteLine(typeof(RollerDerby.Globals).Assembly.GetName().Version);
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"buildType.txt"))
            {
                file.WriteLine(buildType);
            }



        }
    }
}
