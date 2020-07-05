using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private bool attackRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Enemy")
        {
            attackRange = true;
            //EnemyController.Bit(1);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.tag == "Enemy")
        {
            attackRange = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && attackRange)
        {
            EnemyController.Bit(1);
        }
    }
}
