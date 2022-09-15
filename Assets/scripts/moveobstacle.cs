using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class moveobstacle : MonoBehaviour
{
    [SerializeField] float speed = 10;
    private float leftbound = -15;

    private Playercontroller playercontroller;
    // Start is called before the first frame update
    void Start()
    {
        playercontroller = GameObject.Find("Player").GetComponent<Playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playercontroller.gameover==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            }
        }
       
    }
}
