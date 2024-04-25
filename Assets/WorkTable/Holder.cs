using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public int CurrentBoard;    //Int pour savoir quelle planche est déjà sélectionnée
    public int CurrentWheels;   //Int pour savoir quelles roues sont déjà séledctionnées

    //Référence des Roues qu'on fait apparaitre
    public GameObject Wheels1;
    public GameObject Wheels2;
    public GameObject Wheels3;
    public GameObject Wheels4;

    //Référence de la Planche et des Trucks qu'on fait apparaitre
    public GameObject Plank;
    public GameObject Truck1;
    public GameObject Truck2;

    // Start is called before the first frame update
    void Start()
    {
        CurrentBoard = 0;   //Aucune board n'est placé au début du jeu, donc la variable est mise à 0
        CurrentWheels = 0;  //Aucune roues ne sont placées au début du jeu, donc la variable est mise à 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
