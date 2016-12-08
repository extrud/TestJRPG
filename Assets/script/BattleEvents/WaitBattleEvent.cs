using System;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

class WaitBattleEvent : IBattleEvent
{
    Battle btl;
    float time;
    public WaitBattleEvent(float time = 1f)
    {
        this.time = time;
    }
    IEnumerator Wait(float time)
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(time);
        Debug.Log("!");
        btl.EventEnd();
    }
    public override void Activate(Battle bttl)
    {
        btl = bttl;

        btl.StartCoroutine(Wait(time));
    }
    public void WaitEnd()
    {
      
    }
}

