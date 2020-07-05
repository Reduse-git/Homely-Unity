using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BuildController : MonoBehaviour
{
    private GameObject canvas;
    public GameObject player;
    public GameObject wallw;
    public Canvas buildMenu;
    private GameObject c;
    private bool paySomeWall = false;
   
    private bool exist = true;
    // Start is called before the first frame update
    void Start()
    {
        canvas=GameObject.Find ("BuildMenu") as GameObject;
 
        canvas.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && exist)
        {
            canvas.SetActive(true);
            exist = false;
        }
        else if(Input.GetKeyDown(KeyCode.I) && !exist)
        {
            canvas.SetActive(false);
            exist = true;
        }
    }

    public void CreateWall()
    {    
        if (InventoryScript.res != 0)
        {
            c = Instantiate(wallw);
                c.transform.position = player.transform.position;


            canvas.SetActive(false);
            exist = true;
            paySomeWall = true;
            
        }
    }

    void FixedUpdate()
    {
        if (paySomeWall)
        {
            InventoryScript.CostBuild(1);
            paySomeWall = false;
        }

        
    }
}
