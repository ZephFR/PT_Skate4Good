using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerBrain : MonoBehaviour
{

    [Header("Référence a Holder, image et ses variables")]
    public Holder Holder;
    public GameObject Order;
    public GameObject EndPosforOrder;
    private int SpawnedPlank;
    private int SpawnedWheel;

    [Header("Commande")]
    public int DesiredPlank;
    public int DesiredWheel;

    [Header("Score")]
    public int Score;
    public bool CommandeFinie;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnedPlank = Holder.CurrentBoard;
        SpawnedWheel = Holder.CurrentWheels;
    }

    // Update is called once per frame
    void Update()
    {
        Order.transform.position = Vector3.MoveTowards(Order.transform.position, EndPosforOrder.transform.position, Holder.Speed);
        if (CommandeFinie)
        {
            if (SpawnedPlank == DesiredPlank)
            {
                Debug.Log("Bonne Planche");
                Score = +1;
            }
            else if (DesiredPlank == 0)
            {
                Debug.Log("Aucune planche demandé donc hassoul");
                Score = +1;
            }
            else
            {
                Debug.Log("Mauvaise Planche");
            }

            if (SpawnedWheel == DesiredWheel)
            {
                Debug.Log("Bonne Roue");
                Score = +1;
            }
            else if (DesiredWheel == 0)
            {
                Debug.Log("Aucune roues demandé donc hassoul");
                Score = +1;
            }
            else
            {
                Debug.Log("Mauvaises Roues");
            }
        }
    }
}