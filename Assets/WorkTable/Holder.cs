using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    [Header("Int de repérage")]
    public int CurrentBoard;    //Int pour savoir quelle planche est déjà sélectionnée
    public int CurrentWheels;   //Int pour savoir quelles roues sont déjà séledctionnées

    [Header("Positions roues Standard Board")]
    public Transform Pos1Standard;
    public Transform Pos2Standard;
    public Transform Pos3Standard;
    public Transform Pos4Standard;


    [Header("Positions roues Penny Board")]
    public Transform Pos1Penny;
    public Transform Pos2Penny;
    public Transform Pos3Penny;
    public Transform Pos4Penny;

    [Header("Positions roues LongBoard")]
    public Transform Pos1Long;
    public Transform Pos2Long;
    public Transform Pos3Long;
    public Transform Pos4Long;

    [Header("Références publiques aux roues qui vont apparaitre")]//Référence des Roues qu'on fait apparaitre
    public GameObject WheelRef1;
    public GameObject WheelRef2;
    public GameObject WheelRef3;
    public GameObject WheelRef4;

    [Header("Références publiques a la planche & Truck qui vont apparaitre")]//Référence de la Planche et des Trucks qu'on fait apparaitre
    public GameObject Plank;
    public GameObject Truck1;
    public GameObject Truck2;

    [Header("Positions des roues")]
    public Transform WheelPos1;
    public Transform WheelPos2;
    public Transform WheelPos3;
    public Transform WheelPos4;

    // Start is called before the first frame update
    void Start()
    {
        CurrentBoard = 0;   //Aucune board n'est placé au début du jeu, donc la variable est mise à 0
        CurrentWheels = 0;  //Aucune roues ne sont placées au début du jeu, donc la variable est mise à 0
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentBoard == 0)
        {
            Debug.Log("Aucune Planche n'a été séléctionné, donc dodo");
        }
        else if (CurrentBoard == 1) //CurrentBoard = 1 alors une planche Standard est apparue
        {
            WheelPos1 = Pos1Standard;
            WheelPos2 = Pos2Standard;
            WheelPos3 = Pos3Standard;
            WheelPos4 = Pos4Standard;
        }
        else if (CurrentBoard == 2) //CurrentBoard = 2 alors une planche Longboard est apparue
        {
            WheelPos1 = Pos1Long;
            WheelPos2 = Pos2Long;  
            WheelPos3 = Pos3Long;
            WheelPos4 = Pos4Long;
        }
        else if (CurrentBoard == 3) //CurrentBoard = 2 alors une planche Penny est apparue
        {
            WheelPos1 = Pos1Penny;
            WheelPos2 = Pos2Penny;
            WheelPos3 = Pos3Penny;
            WheelPos4 = Pos4Penny;
        }
    }
}
