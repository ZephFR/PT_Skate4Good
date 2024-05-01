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

    public Transform PlankSpawnInfoFC;
    public Transform Truck1SpawnFC;
    public Transform Truck2SpawnFC;

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

            Holder.PlankFC = Instantiate(Plank, PlankSpawnInfoFC);
            Holder.Truck1FC = Instantiate(Truck, Truck1SpawnFC);
            Holder.Truck2FC = Instantiate(Truck, Truck2SpawnFC);
            Debug.Log("Item Has Spawned");
            Holder.CurrentBoard = BoardID;
        }
        else
        {
            Destroy(Holder.Plank);
            Destroy(Holder.Truck1);
            Destroy(Holder.Truck2);
            Destroy(Holder.WheelRef1);
            Destroy(Holder.WheelRef2);
            Destroy(Holder.WheelRef3);
            Destroy(Holder.WheelRef4);

            Destroy(Holder.PlankFC);
            Destroy(Holder.Truck1FC);
            Destroy(Holder.Truck2FC);
            Destroy(Holder.WheelRef1FC);
            Destroy(Holder.WheelRef2FC);
            Destroy(Holder.WheelRef3FC);
            Destroy(Holder.WheelRef4FC);

            Holder.Plank = Instantiate(Plank, PlankSpawnInfo);
            Holder.Truck1 = Instantiate(Truck, Truck1Spawn);
            Holder.Truck2 = Instantiate(Truck, Truck2Spawn);

            Holder.PlankFC = Instantiate(Plank, PlankSpawnInfoFC);
            Holder.Truck1FC = Instantiate(Truck, Truck1SpawnFC);
            Holder.Truck2FC = Instantiate(Truck, Truck2SpawnFC);
            Debug.Log("Item Has Succesfully Been Replaced");
            Holder.CurrentBoard = BoardID;
        }
    }
}
