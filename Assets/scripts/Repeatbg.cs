using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeatbg : MonoBehaviour
{
    private Vector3 startpos;
    private float rpeatwidth;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        rpeatwidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startpos.x - rpeatwidth)
        {
            transform.position = startpos;
            
        }  
    }
}
