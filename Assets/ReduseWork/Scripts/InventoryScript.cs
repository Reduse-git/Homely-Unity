using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public List<GameObject> inventory;
    public List<GameObject> allResource;
    public Transform player;

    public static int res;
    
    
    private GameObject resource;
    // Start is called before the first frame update
    
    void Start()
    {
        allResource.AddRange(GameObject.FindGameObjectsWithTag("Resource"));
    }

    
    // Update is called once per frame
    public void catchResource()
    {
        foreach (GameObject resource1 in allResource)
        {

            float dist = Vector3.Distance(resource1.transform.position, transform.position);
            if (dist < 1)
            {
                GameObject wood = new GameObject("Wood");
                inventory.Add(wood);
                Destroy(resource1, .2f);
                allResource.Remove(resource1);
                res += 1;
            }
        }

    }

    void FixedUpdate()
    {   
        //allResource.Add(GameObject.FindGameObjectsWithTag("Resource"));
        

        

    }

    public static int CostBuild(int i)
    {
        res = res - i;
        return res;
    }

    public int CountRes()
    {
        return res;
    }
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.F))
        {
           catchResource();
        }
    }
}
