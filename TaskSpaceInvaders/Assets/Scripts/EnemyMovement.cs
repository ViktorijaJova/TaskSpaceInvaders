using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float cycleWidth;
    public float frequency;
    public float velocity;
    public float Cy;
    public float Cx;
    public float counter;
    public float xSin;
    void Start()
    {
        Cy = transform.position.y;
        Cx = transform.position.x;
        
    }

    void Update()
    {
        Cy = Cy - velocity;
        counter = counter + (frequency / 100);
        xSin = Mathf.Sin(counter);
        transform.position = new Vector3(Cx + (xSin * cycleWidth), Cy, 0);
        if(counter> 6.28f)
        {
            counter = 0;
        }
    }
}
