using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject HitEffect;

  public float explotionDuration = 0.5f;

    void OnCollisionEnter2D(Collision2D collision) {
     if (!collision.gameObject.CompareTag("Player")) {
      GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
      Destroy(effect,explotionDuration);
      Destroy(gameObject);  
    }}



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
