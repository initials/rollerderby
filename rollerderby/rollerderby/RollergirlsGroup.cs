
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
    class RollergirlsGroup : FlxGroup
    {

        public RollergirlsGroup()
            : base()
        {
            
        }

        /// <summary>
        /// The Update Cycle. Called once every cycle.
        /// </summary>
        override public void update()
        {
            base.update();
        }

        /// <summary>
        /// The render code. Add any additional render code here.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public override void render(SpriteBatch spriteBatch)
        {
            int i = 0;
            FlxObject o;
            int ml = members.Count;


            // sort members by y to draw correctly.
            members = members.OrderBy(d => d.y).ToList() ;


            while (i < ml)
            {
                o = members[i++] as FlxObject;
                if ((o != null) && o.exists && o.visible)
                    o.render(spriteBatch);
            }

        }

        
    }
}
