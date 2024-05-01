using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    public Holder Holder;
    public GameObject DisplayedObjectForTrigger;

    public bool isItemAWheel;
    // Update is called once per frame
    private void OnMouseOver()
    {
        if (isItemAWheel)
        {
            if (Holder.CurrentBoard != 0)
            {
                DisplayedObjectForTrigger.GetComponent<Outline>().enabled = true;
                DisplayedObjectForTrigger.GetComponent<Outline>().OutlineColor = Color.white;
                DisplayedObjectForTrigger.GetComponent<Outline>().OutlineWidth = 3.55f;
            }
            else
            {
                DisplayedObjectForTrigger.GetComponent<Outline>().enabled = true;
                DisplayedObjectForTrigger.GetComponent<Outline>().OutlineColor = Color.black;
                DisplayedObjectForTrigger.GetComponent<Outline>().OutlineWidth = 2;
            }
        }
        else
        {
            DisplayedObjectForTrigger.GetComponent<Outline>().enabled = true;
            DisplayedObjectForTrigger.GetComponent<Outline>().OutlineColor = Color.white;
        }
    }

    private void OnMouseExit()
    {
        DisplayedObjectForTrigger.GetComponent<Outline>().enabled = false;
    }
}
