using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class NPCBattleEvent : IBattleEvent
{
    Battle btl;
    BattleCharacter bc;
    public NPCBattleEvent(BattleCharacter btc)
    {
        bc = btc;
    }
  
    public override void Activate(Battle bttl)
    {
        this.btl = bttl;
        btl.AddEvent(new BattleMassage("HI!"));
        bttl.AddEvent(new BattleMassage("Iam NPC"));
        bttl.AddEvent(new BattleMassage("My name"+bc.Name));
        btl.EventEnd();
       

    }
    public void End()
    {

        
    }

}

