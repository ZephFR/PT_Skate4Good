using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsSpawn : MonoBehaviour
{
    public GameObject SelectedWheels;
    public Transform Pos1;
    public Transform Pos2;
    public Transform Pos3;
    public Transform Pos4;
    
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
        Instantiate(SelectedWheels, Pos1);
        Instantiate(SelectedWheels, Pos2);
        Instantiate(SelectedWheels, Pos3);
        Instantiate(SelectedWheels, Pos4);
    }
}
