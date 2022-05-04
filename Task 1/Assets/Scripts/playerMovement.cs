using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public List<Transform>  cubes;
    int i = 0;

    void Start()
    {
                
        
    }

    // Move to the target end position.
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.position = Vector3.MoveTowards(transform.position , cubes[i].position,0.1f);
            if(transform.position == cubes[i].position)
            {
                i++;
                if (i >= cubes.Count)
                {
                    i = 0;
                }
            }
        }
    }
}
