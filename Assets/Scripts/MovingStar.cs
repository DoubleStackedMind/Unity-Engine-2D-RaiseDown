using UnityEngine;
using UnityEngine.UI;

public class MovingStar : MonoBehaviour {

    public Rigidbody2D rg;

    // Speed in units per sec.
    public float speed = 5f;
    private bool dirRight = true;

    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody2D>();
    }

     void FixedUpdate() 
    {
        if (dirRight)
        //    rg.AddForce(new Vector2(20, 0), ForceMode2D.Impulse);
         transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
       transform.Translate(-Vector2.right * speed * Time.deltaTime);
            
          //  rg.AddForce(new Vector2(-40, 0), ForceMode2D.Impulse);
       

        if (transform.position.x >= 4.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4)
        {
            dirRight = true;
        }
    }
}
