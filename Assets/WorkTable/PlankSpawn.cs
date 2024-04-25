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
    public Holder Holder;

    public int BoardID;

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
        if (Holder.CurrentBoard == 0) 
        { 
            Holder.Plank = Instantiate(Plank, PlankSpawnInfo);
            Holder.Truck1 = Instantiate(Truck, Truck1Spawn);
            Holder.Truck2 = Instantiate(Truck, Truck2Spawn);
            Debug.Log("Item Has Spawned");
            Holder.CurrentBoard = BoardID;
        }
        else
        {
            Destroy(Holder.Plank);
            Destroy(Holder.Truck1);
            Destroy(Holder.Truck2);
            Destroy(Holder.Wheels1);
            Destroy(Holder.Wheels2);
            Destroy(Holder.Wheels3);
            Destroy(Holder.Wheels4);
                
            Holder.Plank = Instantiate(Plank, PlankSpawnInfo);
            Holder.Truck1 = Instantiate(Truck, Truck1Spawn);
            Holder.Truck2 = Instantiate(Truck, Truck2Spawn);
            Debug.Log("Item Has Succesfully Been Replaced");
            Holder.CurrentBoard = BoardID;
        }
    }
}
