using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public int CurrentBoard;    //Int pour savoir quelle planche est d�j� s�lectionn�e
    public int CurrentWheels;   //Int pour savoir quelles roues sont d�j� s�ledctionn�es

    //R�f�rence des Roues qu'on fait apparaitre
    public GameObject Wheels1;
    public GameObject Wheels2;
    public GameObject Wheels3;
    public GameObject Wheels4;

    //R�f�rence de la Planche et des Trucks qu'on fait apparaitre
    public GameObject Plank;
    public GameObject Truck1;
    public GameObject Truck2;

    // Start is called before the first frame update
    void Start()
    {
        CurrentBoard = 0;   //Aucune board n'est plac� au d�but du jeu, donc la variable est mise � 0
        CurrentWheels = 0;  //Aucune roues ne sont plac�es au d�but du jeu, donc la variable est mise � 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
