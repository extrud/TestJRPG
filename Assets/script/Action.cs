using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class BattleAction
    {
    public BattleAction(Battle battle)
    {
        this.battle = battle;
    }
        public Battle battle;
        public List<string> Tags = new List<string>();

    }

