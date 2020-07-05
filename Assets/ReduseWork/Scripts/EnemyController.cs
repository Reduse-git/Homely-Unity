using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            PlayerController.Bit(1);
        }
    } 
}
