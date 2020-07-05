using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallProperty : MonoBehaviour
{
    private int helth = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (helth <= 0)
        {
            Destroy(gameObject,.3f);
        }
    }
}
