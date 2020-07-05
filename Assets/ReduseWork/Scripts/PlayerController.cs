using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public static int helth = 3;

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
    public static int Bit(int i)
    {
        helth = helth - i;
        return helth;
    }
    public static int CountHelth()
    {
        return helth;
    }
    void destroy()
    {
        Destroy(main,.5f);
    }
}
