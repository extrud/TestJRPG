using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MessageEvent : IBattleEvent
{
    Battle btl;
    public override void Activate(Battle bttl)
    {
        btl = bttl;

    }
}

