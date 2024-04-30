using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsSpawn : MonoBehaviour
{
    [Header("Données Unique")]
    public GameObject SelectedWheels;
    public int WheelsID;

    [Header("Référence a Holder")]
    public Holder Holder;

    private void OnMouseDown()
    {
        if (Holder.CurrentBoard == 0)
        {
            Debug.Log("Aucune planche n'a été sélectionnée, aucune roue ne sera alors placée");
        }
        else
        {
            if (Holder.CurrentWheels == 0) { 
                Holder.WheelRef1 = Instantiate(SelectedWheels, Holder.WheelPos1);
                Holder.WheelRef2 = Instantiate(SelectedWheels, Holder.WheelPos2);
                Holder.WheelRef3 = Instantiate(SelectedWheels, Holder.WheelPos3);
                Holder.WheelRef4 = Instantiate(SelectedWheels, Holder.WheelPos4);
                Holder.CurrentWheels = WheelsID;
                Debug.Log("Wheels Has Been Spawned");
            }
            else
            {
                Destroy(Holder.WheelRef1);
                Destroy(Holder.WheelRef2);
                Destroy(Holder.WheelRef3);
                Destroy(Holder.WheelRef4);
                Debug.Log("Wheels Has Been Destroyed");

                Holder.WheelRef1 = Instantiate(SelectedWheels, Holder.WheelPos1);
                Holder.WheelRef2 = Instantiate(SelectedWheels, Holder.WheelPos2);
                Holder.WheelRef3 = Instantiate(SelectedWheels, Holder.WheelPos3);
                Holder.WheelRef4 = Instantiate(SelectedWheels, Holder.WheelPos4);
                Holder.CurrentWheels = WheelsID;
                Debug.Log("Wheels Has Succesfully Been Replaced");
            }
        }
    }
}
