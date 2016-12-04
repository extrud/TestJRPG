using UnityEngine;
using System.Collections;

public static class Extencion
{
    public static Vector3 V3(this Vector2 v2)
    {
        return new Vector3(v2.x, v2.y);
    }
}

public class MoveScript : MonoBehaviour {
    Vector2 moveVector;
    Rigidbody2D rb2d;
    public bool AutoCreateRb = true;
   
    // Use this for initialization
	void Start () {

       
        if (GetComponent<Rigidbody2D>() == null && AutoCreateRb)
        {
            rb2d = gameObject.AddComponent<Rigidbody2D>();
            rb2d.gravityScale = 0;
            rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb2d.drag = 1;

        }
        else
        {
            rb2d = GetComponent<Rigidbody2D>();
        }
	}
    public void SetMVector( Vector2 v2)
    {
        moveVector = v2;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb2d.MovePosition(transform.position + (moveVector.V3()) * Time.fixedDeltaTime);
        moveVector = Vector2.zero;
	}
}
