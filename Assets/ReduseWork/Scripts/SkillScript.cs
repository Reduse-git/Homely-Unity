using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillScript : MonoBehaviour
{
	
	public bool repairer;
	public bool repairer2;
	


	private bool bookBehaind;
	private bool a1;
	private bool a2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Repairer")
        { 
            bookBehaind = true;
			a1= true;

        }
		if (collision.gameObject.tag == "Repairer2")
        { 
            bookBehaind = true;
			a2= true;
        }
	}
void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Repairer")
        { 
            bookBehaind = false;
			a1= false;
        }
		if (collision.gameObject.tag == "Repairer2")
        { 
            bookBehaind = false;
			a2= false;
        }

	}	

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && bookBehaind && a1)
                {
                   		repairer = true;
						GameObject bookRepairer = GameObject.FindGameObjectWithTag("Repairer");
						Destroy(bookRepairer,.1f);
                }
			if (Input.GetKeyDown(KeyCode.F) && bookBehaind && repairer && a2)
                {
                   		repairer2 = true;
						GameObject bookRepairer2 = GameObject.FindGameObjectWithTag("Repairer2");
						Destroy(bookRepairer2,.1f);
                }
    }
}
