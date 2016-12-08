using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    class TestBattleEvent : IBattleEvent
    {
        string mess;
    public TestBattleEvent(string msg)
    {
        mess = msg;
    }

        Battle bttl;

        public override void Activate(Battle bttl)
        {
            this.bttl = bttl;
            Debug.Log(mess);
            bttl.AddEvent(new BattleMassage("myTurn"));
            bttl.EventEnd();
        }
    }

