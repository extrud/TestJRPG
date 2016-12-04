using UnityEngine;
using System.Collections.Generic;

public class Battle : MonoBehaviour {

    bool End;
    BattleCharacter charL;
    BattleCharacter charR;
    BattleCharacter CurrentCharacter;
    List<IBattleEvent> Events = new List<IBattleEvent>();
    public void EventEnd()
    {
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
    }

	void Update () {
	
	}
}
