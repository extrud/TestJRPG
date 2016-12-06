using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class BattleCharacter
    {
        public BattleCharacter(string name,int HP,string status,Battle battle,IBattleEvent Action)
        {
         this.Name = name;
            this.HP = HP;
            this.status = status;
            this.battle = battle;
            this.Action = Action;
        }
    protected string Name;
        protected int HP;
        protected string status;
        protected Battle battle;
        public protected IBattleEvent Action;
        virtual public TakeDMG(int count,Battle btl)
        {
        }
        public abstract void Reaction(BattleAction act);
     

    }

