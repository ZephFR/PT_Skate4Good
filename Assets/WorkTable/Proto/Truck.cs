using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{

    public Transform TruckObj;
    public int spawnX;
    public int spawnY;
    public int spawnZ;

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
        Instantiate(TruckObj, new Vector3(spawnX, spawnY, spawnZ), TruckObj.rotation);
    }
}
