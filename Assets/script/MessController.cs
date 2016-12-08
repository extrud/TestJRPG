using UnityEngine;
using System.Collections;


public class MessController : MonoBehaviour {
    public GameObject MessagePrefab;
    public GameObject PlayerActionPrefub;
    Mess mess;
    PlayerActionWindow paw;
    public PlayerActionWindow CreatePlAW()
    {
       paw = ((GameObject)Instantiate(PlayerActionPrefub, this.transform.position, this.transform.rotation, this.transform)).GetComponent<PlayerActionWindow>();
       
    }
    public Mess CreateDlg(string str)
    {
       
        mess = ((GameObject)Instantiate(MessagePrefab, this.transform.position,this.transform.rotation,this.transform)).GetComponent<Mess>();
        mess.mc = this;
        mess.SetText(str);
        return mess;
      
    }

}
