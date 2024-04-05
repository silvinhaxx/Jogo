using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class Serra : MonoBehaviour
{
    public Transform PontA;
    public Transform PontB;
    public float speed;

    private Vector3 targetPosition;


    private void Start()
    {
        targetPosition = PontB.position;
        transform.position = targetPosition;
       
    }
    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, targetPosition);

        if(distance < 0.01)
        {
            if (targetPosition == PontB.position)
            {
                targetPosition = PontA.position;
            }
            else
            {
                targetPosition = PontB.position;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
    
   

}

