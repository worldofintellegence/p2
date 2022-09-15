using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovment : MonoBehaviour
{
    [SerializeField] float speed = 2;
    public GameObject[] smallsballs;
    public GameObject[] secondarray;
    private Vector3 spawningpoint;
   

    private void Start()
    {
      
    }
    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if(transform.position.y>19)
        {
            Destroy(gameObject);
            
        }
    }
   
   void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Balls"))
        {
            Debug.Log("A");
            Destroy(collision.gameObject);
            spawningpoint = collision.transform.position;
            Instantiate(smallsballs[0], spawningpoint, Quaternion.identity);
            Instantiate(smallsballs[1], spawningpoint, Quaternion.identity);
        }
        if(collision.gameObject.CompareTag("small ball"))
        {
            Destroy (collision.gameObject);
            spawningpoint = collision.transform.position;
            Instantiate(secondarray[0], spawningpoint, Quaternion.identity);
            Instantiate(secondarray[1], spawningpoint, Quaternion.identity);
        }
    }

}
