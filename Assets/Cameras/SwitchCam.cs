using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;

    private int Manager;


    public void ChangeCamera()
    {
        GetComponent<Animator>().SetTrigger("Change");
    }

    public void ManageCameras()
    {
        if (Manager == 0)
        {
            Cam_1();
            Manager = 1;
        }
        else
        {
            Cam_2();
            Manager = 0;
        }
    }
    void Cam_1()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
    }

    void Cam_2()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(true);
    }
}
