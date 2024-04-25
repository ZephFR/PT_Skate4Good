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
    public Holder Holder;

    public int WheelsID;
    
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
            Debug.Log("Aucune planche n'a été sélectionnée, aucune roue ne sera alors placée");
        }
        else
        {
            if (Holder.CurrentWheels == 0) { 
                Holder.Wheels1 = Instantiate(SelectedWheels, Pos1);
                Holder.Wheels2 = Instantiate(SelectedWheels, Pos2);
                Holder.Wheels3 = Instantiate(SelectedWheels, Pos3);
                Holder.Wheels4 = Instantiate(SelectedWheels, Pos4);
                Holder.CurrentWheels = WheelsID;
                Debug.Log("Wheels Has Been Spawned");
            }
            else
            {
                Destroy(Holder.Wheels1);
                Destroy(Holder.Wheels2);
                Destroy(Holder.Wheels3);
                Destroy(Holder.Wheels4);

                Holder.Wheels1 = Instantiate(SelectedWheels, Pos1);
                Holder.Wheels2 = Instantiate(SelectedWheels, Pos2);
                Holder.Wheels3 = Instantiate(SelectedWheels, Pos3);
                Holder.Wheels4 = Instantiate(SelectedWheels, Pos4);
                Holder.CurrentWheels = WheelsID;
                Debug.Log("Wheels Has Succesfully Been Replaced");

            }
        }

        
    }
}
