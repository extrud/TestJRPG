using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class BattleCharacter
    {
        public BattleCharacter(string name,int HP,string status,Battle battle)
        {
         this.Name = name;
            this.HP = HP;
            this.status = status;
            this.battle = battle;
           
        }

    private string name;
    protected int HP;
        protected string status;
        protected Battle battle;
        public IBattleEvent Action;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    virtual public void  TakeDMG(int count,Battle btl)
        {
        }
        public abstract void Reaction(BattleAction act);
     

    }

