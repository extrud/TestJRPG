using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Mess : MonoBehaviour {
    public MessController mc;
    public Text txt;
    public delegate void dlgmess(DlgResult dlgr);
    public event dlgmess OnCLose;
    // Use this for initialization
    void Start () {
	
	}
    public void SetText(string str)
    {
        txt.text = str;
    }
    public void Close()
    {

        if (OnCLose != null)
        {
            OnCLose.Invoke(new DlgResult());
        }
        Destroy(this.gameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
