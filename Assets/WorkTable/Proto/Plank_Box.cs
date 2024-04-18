using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank_Box : MonoBehaviour
{

    public Transform PlankObj;

    private int NumberClicks = 0;
    private bool hasSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(PlankObj, new Vector3(1,0,-5.7f), PlankObj.rotation);
        hasSpawned = true;
        NumberClicks = NumberClicks + 1;
        
    }
}
