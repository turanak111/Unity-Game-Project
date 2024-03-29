using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool Running = false;
    bool Moving = false;
    public Animator animator;
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
            Running = true;

        }
        else
        {
            BaseSpeed = InputSpeed;
            Running = false;
        }

        Moving = false;


        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * BaseSpeed * Time.deltaTime, Space.World);
            Moving = true;
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * BaseSpeed * Time.deltaTime, Space.World);
            Moving = true;
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * BaseSpeed * Time.deltaTime, Space.World);
            Moving = true;
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.down * BaseSpeed * Time.deltaTime, Space.World);
            Moving = true;
        }

        animator.SetBool("IsMoving", Moving);
        animator.SetBool("IsRunning", Running);
    




    }







}
