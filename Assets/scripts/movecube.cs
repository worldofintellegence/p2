using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    private void move()
    {
        float x = Input.GetAxis("Horizontal");


        Vector3 movement = new Vector3(x, 0, 0);
        //transform.rotation = Quaternion.LookRotation(movement);
        transform.Translate(movement * 2 * Time.deltaTime);

       /* Play_anim.SetBool("Static_b", true);

        Play_anim.SetFloat("Speed_f", x);
*/
    }
}
