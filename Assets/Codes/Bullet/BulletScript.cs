using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject HitEffect;

    void OnCollisionEnter2D(Collision2D collision) {
      GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
      Destroy(effect,0.5f);
      Destroy(gameObject);  
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
