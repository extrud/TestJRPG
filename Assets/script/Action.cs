using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class BattleAction
    {
    public BattleAction(Battle battle,BattleCharacter from,BattleCharacter to)
    {
        this.battle = battle;
        From = from;
        To = to;
    }
        public BattleCharacter From;
        public BattleCharacter To;
        public Battle battle;
        public List<string> Tags = new List<string>();

    }

