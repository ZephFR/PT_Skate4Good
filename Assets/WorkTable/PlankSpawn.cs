using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankSpawn : MonoBehaviour
{
    public GameObject Plank;
    public GameObject Truck;
    public Transform PlankSpawnInfo;
    public Transform Truck1Spawn;
    public Transform Truck2Spawn;

    private int Clicks;
    // Start is called before the first frame update
    void Start()
    {
        Clicks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(Plank, PlankSpawnInfo);
        Instantiate(Truck, Truck1Spawn);
        Instantiate(Truck, Truck2Spawn);
        Debug.Log("Item Has Spawned");


        Clicks = Clicks + 1;
        Debug.Log(Clicks);  
    }
}
