using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class IBattleEvent
    {

    public abstract void Activate(Battle bttl);
    protected void End(Battle bttl)
        {
            bttl.EventEnd();
        }        
    }

