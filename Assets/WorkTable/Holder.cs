using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Holder : MonoBehaviour
{
    [Header("Références a des Game Objects Extérieur et variables")]
    public SendSkate SS;
    public GameObject EndPosition;
    public SwitchCam SW;
    public float Speed;
    public Button button;
    public float nbCommandesRemplies = 0;
    public CustomerBrain CB;

    [Header("Int de repérage")]
    public int CurrentBoard;    //Int pour savoir quelle planche est déjà sélectionnée
    public int CurrentWheels;   //Int pour savoir quelles roues sont déjà séledctionnées
    [Header("Partie Skate sur le plan de travail")]
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

    
    //---------------------------------------------------------------
    

    [Header("Partie Skate près du client")]
    [Header("Positions roues Standard Board")]
    public Transform Pos1StandardFC;
    public Transform Pos2StandardFC;
    public Transform Pos3StandardFC;
    public Transform Pos4StandardFC;


    [Header("Positions roues Penny Board")]
    public Transform Pos1PennyFC;
    public Transform Pos2PennyFC;
    public Transform Pos3PennyFC;
    public Transform Pos4PennyFC;

    [Header("Positions roues LongBoard")]
    public Transform Pos1LongFC;
    public Transform Pos2LongFC;
    public Transform Pos3LongFC;
    public Transform Pos4LongFC;

    [Header("Références publiques aux roues qui vont apparaitre")]//Référence des Roues qu'on fait apparaitre
    public GameObject WheelRef1FC;
    public GameObject WheelRef2FC;
    public GameObject WheelRef3FC;
    public GameObject WheelRef4FC;
    
    [Header("Références publiques a la planche & Truck qui vont apparaitre")]//Référence de la Planche et des Trucks qu'on fait apparaitre
    public GameObject PlankFC;
    public GameObject Truck1FC;
    public GameObject Truck2FC;

    [Header("Positions des roues")]
    public Transform WheelPos1FC;
    public Transform WheelPos2FC;
    public Transform WheelPos3FC;
    public Transform WheelPos4FC;

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

            WheelPos1FC = Pos1StandardFC;
            WheelPos2FC = Pos2StandardFC;
            WheelPos3FC = Pos3StandardFC;
            WheelPos4FC = Pos4StandardFC;
        }
        else if (CurrentBoard == 2) //CurrentBoard = 2 alors une planche Longboard est apparue
        {
            WheelPos1 = Pos1Long;
            WheelPos2 = Pos2Long;  
            WheelPos3 = Pos3Long;
            WheelPos4 = Pos4Long;

            WheelPos1FC = Pos1LongFC;
            WheelPos2FC = Pos2LongFC;
            WheelPos3FC = Pos3LongFC;
            WheelPos4FC = Pos4LongFC;
        }
        else if (CurrentBoard == 3) //CurrentBoard = 2 alors une planche Penny est apparue
        {
            WheelPos1 = Pos1Penny;
            WheelPos2 = Pos2Penny;
            WheelPos3 = Pos3Penny;
            WheelPos4 = Pos4Penny;

            WheelPos1FC = Pos1PennyFC;
            WheelPos2FC = Pos2PennyFC;
            WheelPos3FC = Pos3PennyFC;
            WheelPos4FC = Pos4PennyFC;
        }

        if (SS.FinishedSkate) //Si le bouton d'envoi de commande est pressé alors ces actions se lancent
        {
            if (CurrentBoard != 0) 
            {
                Plank.transform.position = Vector3.MoveTowards(Plank.transform.position, EndPosition.transform.position, Speed);
                Truck1.transform.position = Vector3.MoveTowards(Truck1.transform.position, EndPosition.transform.position, Speed);
                Truck2.transform.position = Vector3.MoveTowards(Truck2.transform.position, EndPosition.transform.position, Speed);
                if (CurrentWheels != 0)
                {
                    WheelRef1.transform.position = Vector3.MoveTowards(WheelRef1.transform.position, EndPosition.transform.position, Speed);
                    WheelRef2.transform.position = Vector3.MoveTowards(WheelRef2.transform.position, EndPosition.transform.position, Speed);
                    WheelRef3.transform.position = Vector3.MoveTowards(WheelRef3.transform.position, EndPosition.transform.position, Speed);
                    WheelRef4.transform.position = Vector3.MoveTowards(WheelRef4.transform.position, EndPosition.transform.position, Speed);
                }
                SW.stopInteractions = true;
                CB.CommandeFinie = true;
            }
            else
            {
                SS.FinishedSkate = false;
            }
        }
    }

    public void EndOfOrder() //Après le score et le quiz, tout est reset et le joueur peut recommencer avec une nouvelle commande
    {
        Destroy(WheelRef1);
        Destroy(WheelRef2);
        Destroy(WheelRef3);
        Destroy(WheelRef4);
        Destroy(Plank);
        Destroy(Truck1);
        Destroy(Truck2);

        Destroy(WheelRef1FC);
        Destroy(WheelRef2FC);
        Destroy(WheelRef3FC);
        Destroy(WheelRef4FC);
        Destroy(PlankFC);
        Destroy(Truck1FC);
        Destroy(Truck2FC);

        CurrentBoard = 0;
        CurrentWheels = 1;
        SS.FinishedSkate = false;
    }
}
