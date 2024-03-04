using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float InputSpeed;
    public float sprintSpeed;
    float BaseSpeed;

    // Start is called before the first frame update
    void Start()
    {
            BaseSpeed = InputSpeed;
    }

    // Update is called once per frame
    void Update()
    {
         playerMovement();
         


        
    }


void playerMovement()
{

        if (Input.GetKey(KeyCode.LeftShift))
        {
            BaseSpeed = InputSpeed + sprintSpeed;
        }
        else 
        {
            BaseSpeed = InputSpeed;
        }




    if (Input.GetKey(KeyCode.W))
    {
        transform.Translate (Vector3.up * BaseSpeed * Time.deltaTime,Space.World);
    }
    if (Input.GetKey(KeyCode.D))
    {
        transform.Translate (Vector3.right  * BaseSpeed * Time.deltaTime,Space.World);
    }
        if (Input.GetKey(KeyCode.A))
    {
        transform.Translate (Vector3.left * BaseSpeed * Time.deltaTime,Space.World);
    }
        if (Input.GetKey(KeyCode.S))
    {
        transform.Translate (Vector3.down * BaseSpeed * Time.deltaTime,Space.World);
    }







    
 






}







}
