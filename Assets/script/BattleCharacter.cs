using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    abstract class BattleCharacter
    {
        public BattleCharacter(int HP,string status,Battle battle,IBattleEvent Action)
        {
            this.HP = HP;
            this.status = status;
            this.battle = battle;
            this.Action = Action;
        }
        protected int HP;
        protected string status;
        protected Battle battle;
        public protected IBattleEvent Action;

        public abstract void Reaction(BattleAction act);
     

    }

