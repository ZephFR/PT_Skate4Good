using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendSkate : MonoBehaviour
{
    public bool FinishedSkate;

    private void OnMouseDown()
    {
        FinishedSkate = true;
    }
}
