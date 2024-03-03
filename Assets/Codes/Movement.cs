using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    bool BoolSpeed = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         playerMovement();
         


        
    }


void playerMovement()
{


    if (BoolSpeed == true)
    {
        speed += 3;
    }

    if (Input.GetKey(KeyCode.W))
    {
        transform.Translate (Vector3.up * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D))
    {
        transform.Translate (Vector3.right  * speed * Time.deltaTime);
    }
        if (Input.GetKey(KeyCode.A))
    {
        transform.Translate (Vector3.left * speed * Time.deltaTime);
    }
        if (Input.GetKey(KeyCode.S))
    {
        transform.Translate (Vector3.down * speed * Time.deltaTime);
    }

            if (BoolSpeed == true)
    {
        speed -= 3;
    }





    
         if (Input.GetKey(KeyCode.LeftShift))
    {
        BoolSpeed = true;
    }
    else
    {
        BoolSpeed = false;
    }





}







}
