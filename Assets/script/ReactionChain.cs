using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ReactionChain
    {
    public bool Onetime;
    List<string> Tags = new List<string>();
    List<IBattleEvent> Events = new List<IBattleEvent>();
    ReactionChain Next;
    public void React(BattleAction ba)
    {
        bool ok = false;
        foreach (var t in ba.Tags)
        {
            if (ok)
            {
                break;
            }
            foreach (var t2 in Tags)
            {
                if (t2 == t)
                {
                    ok = true;
                    break;
                }
            }
        }

        if (ok)
        {
            foreach (var ev in Events)
            {
                ev.Activate(ba)
            }
        }
        else
        {
            Next.React(ba);
        }
    }
    }

