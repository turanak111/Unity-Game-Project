using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Crosshaircontrol : MonoBehaviour
{
    public float InputSpeed;
    public float sprintSpeed;
    float BaseSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        BaseSpeed = InputSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        crossMovement();
          // Mouse'un konumunu al
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Crosshair'ın Z bileşenini kamera ile aynı seviyeye getir

        // Crosshair'ı mouse'un konumuna taşı
        transform.position = mousePosition;



    }


    void crossMovement()
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
            transform.Translate(Vector3.up * BaseSpeed * Time.deltaTime, Space.World);
          
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * BaseSpeed * Time.deltaTime, Space.World);
          
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * BaseSpeed * Time.deltaTime, Space.World);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * BaseSpeed * Time.deltaTime, Space.World);
           
        }





    }







}
