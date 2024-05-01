using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerBrain : MonoBehaviour
{

    [Header("Référence a Holder et ses variables")]
    public Holder Holder;
    private int SpawnedPlank;
    private int SpawnedWheel;
    private int SpawnedGrip;

    [Header("Commande")]
    public string CustommmerName;
    public Image CustommerOrder;
    public int DesiredPlank;
    public int DesiredWheel;
    public int DesiredGrip;

    [Header("Quiz")]
    public string jmenbaslescouilles;
    //a faire

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
