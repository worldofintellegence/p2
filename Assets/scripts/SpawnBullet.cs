using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject bullet_prefab;
    public Transform firepoint;
   // public Transform ballpoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            Instantiate(bullet_prefab, transform.position, firepoint.rotation);

        }

    }
   
}
