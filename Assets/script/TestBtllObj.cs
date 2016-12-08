using UnityEngine;
using System.Collections;

public class TestBtllObj : MonoBehaviour {
    Battle Btl;
    // Use this for initialization
    void Start () {
        Btl =this.gameObject.AddComponent<Battle>();
        Btl.mc = GameObject.Find("MC").GetComponent<MessController>();
        BattleCharacter bch2 = new TestBattlecharacter("Alfred", 10, "normal", Btl);
        bch2.Action = new NPCBattleEvent(bch2);
        BattleCharacter bch1 = new TestBattlecharacter("test1", 10, "normal", Btl);
        bch1.Action = new TestBattleEvent("Test Battle Event");
        Btl.charL = bch1;
        Btl.charR = bch2;
        Btl.EventEnd();
    
  
    }
	
	// Update is called once per frame
	void Update () {
      
	}
}
