using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    
    MoveScript mvs;
    public bool AutoCreateMs = true;
    public float speed = 10f;
    // Use this for initialization
    void Start () {
        if (GetComponent<MoveScript>() == null && AutoCreateMs)
        {
            mvs = gameObject.AddComponent<MoveScript>();

        }
        else
        {
            mvs = GetComponent<MoveScript>();
        }
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 axis;
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");

        if (axis != null)
        {
            mvs.SetMVector(axis * speed);
        }
	}
}
