using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.script
{
    class BattleMassage : IBattleEvent
    {
        Battle bttl;
        public void Activate(Battle bttl)
        {
            this.bttl = bttl; 
        }

        public void End()
        {
            
        }
    }
}
