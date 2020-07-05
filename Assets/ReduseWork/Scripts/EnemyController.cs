using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public GameObject main;
	public static int helth = 3;
    private Transform target;
    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        if (PlayerController.helth > 0)
        {
            target = player.GetComponent<Transform>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.helth > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
	void FixedUpdate(){
		if (helth <= 0)
        {
            Destroy(main,.5f);
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            PlayerController.Bit(1);
        }
    } 
	public static int Bit(int i)
    {
        helth = helth - i;
        return helth;
    }
}
