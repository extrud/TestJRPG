using UnityEngine;
using System.Collections.Generic;

public class Battle:MonoBehaviour  {

    bool End;
   
    public BattleCharacter charL;
    public BattleCharacter charR;
    BattleCharacter CurrentCharacter;
    public MessController mc;
    List<IBattleEvent> Events = new List<IBattleEvent>();
    void Start()
    {
        mc = GameObject.Find("MC").GetComponent<MessController>();
    }
   public  Mess CreateMess(string str)
    {

        return mc.CreateDlg(str);
    }
    public void AddEventNext(IBattleEvent ev)
    {
        Events.Insert(1, ev);
    }
    public void AddEvent( IBattleEvent ibe)
    {
        Events.Add(ibe);
    }
    public void NextEvent()
    {
        Events[0].Activate(this);
    }
    public void EventEnd()
    {
       
        if(Events.Count>0)
            Events.RemoveAt(0);
        if (End)
        {
            return;
        }
        if (Events.Count==0)
        {
        
      
                if (CurrentCharacter == charL)
                {
                    CurrentCharacter = charR;
                }
                else
                {
                    CurrentCharacter = charL;
                }

            Events.Add(CurrentCharacter.Action);
            
        }
        NextEvent();
    }
    
	void Update () {
	
	}
}
