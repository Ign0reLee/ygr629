using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Movement : MonoBehaviour
{
    Vector2 StartPosition;
    Vector2 Destination;
    Vector2 CurrentPosition;
    float length;
    int button = 0;
    float speed = 0.001f;


    void start()
    {
        Destination = transform.position;

    }
    void Update()
    {
        Destination = new Vector2(-8.44f, -1.47f);

        if (Input.GetMouseButton(0))
        {
            button = 1;
        }
        if (button == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, Destination, 5.0f * Time.deltaTime);
            length = this.Destination.x - this.transform.position.x;
            if (length == 0)
            {
                button = 0;
                }
        }
        //City Loaction = new City();
        /*CurrentPosition = transform.position;
        Destination =  new Vector2(-8.44f, -1.47f);
        transform.position = Vector2.MoveTowards(CurrentPosition, Destination, 5.0f * Time.deltaTime);
        */
    }
}
 
