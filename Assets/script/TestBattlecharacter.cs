using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class TestBattlecharacter : BattleCharacter
    {
        public TestBattlecharacter(string name, int HP, string status, Battle battle) : base(name, HP, status, battle)
        {
        }

        public override void Reaction(BattleAction act)
        {
           
        }
    }

