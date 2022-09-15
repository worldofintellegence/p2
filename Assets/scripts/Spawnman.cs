using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnman : MonoBehaviour
{
    private int numselector = 4;
    public GameObject[] Enemy;
    Vector3 wheretospawn;
    float startdelay = 12;
    float rpeatrate = 12;
    float randx;
  


    // Start is called before the first frame update
    void Start()
    {
        //Enemy = new GameObject[numselector];
        InvokeRepeating("spawnball", startdelay, rpeatrate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void spawnball()
    {
        foreach (GameObject enemy in Enemy)
        {
            randx = Random.Range(-14, 14);
            wheretospawn = new Vector3(randx, transform.position.y, 0);
            Instantiate(enemy, wheretospawn, Quaternion.identity);
        }
        
    }

}
     


