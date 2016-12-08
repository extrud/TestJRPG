using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class BattleMassage : IBattleEvent
    {
        Battle bttl;
    string mess;
        public BattleMassage(string str)
    {
        mess = str;
    }
        public override void Activate(Battle bttl)
        {
            this.bttl = bttl;
            bttl.CreateMess(mess).OnCLose+=OnDlgClose;
        bttl.AddEventNext(new WaitBattleEvent(0.5f));
       
         }

    public void OnDlgClose(DlgResult dlr)
    {
        End();
    }
        public void End()
        {
      
            bttl.EventEnd();
        }
    }

