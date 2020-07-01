using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public int helth;

    public float speed;
    public GameObject main;
    private Rigidbody2D rb;
    private Vector2 mv;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 mi = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        mv = mi.normalized * speed;
        
        

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);

        if (helth <= 0)
        {
            destroy();
        }
    }

    void destroy()
    {
        Destroy(main,.5f);
    }
}
