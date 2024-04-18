using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehaviour : MonoBehaviour
{

    public enum Demands
    {

    }

    [SerializeField] Transform[] points;
    [SerializeField] private float speed;
    private int pointsIndex;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[pointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pointsIndex);
        if (pointsIndex == 2)
        {
            Debug.Log("AAAAAAAAAAAAAAAAA");
            new WaitForSeconds(5);
            transform.position = Vector3.MoveTowards(transform.position, points[pointsIndex].transform.position, speed * Time.deltaTime);
            if (pointsIndex <= points.Length - 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, points[pointsIndex].transform.position, speed * Time.deltaTime);

                if (transform.position == points[pointsIndex].transform.position)
                {
                    pointsIndex += 1;
                }
            }
        }
        else if (pointsIndex <= points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[pointsIndex].transform.position, speed * Time.deltaTime);

            if (transform.position == points[pointsIndex].transform.position)
            {
                pointsIndex += 1;
            }

        }
    }
}
