using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Animator animator;
    public bool isshootingbool;
    public AudioClip ShootingSound;
    public AudioClip ReloadiongSound;
    public AudioClip BulletShellSound;
    public AudioSource audioSource;
    bool reloadingBoolean = false;
    public float shakingDuration;
    public float shakingMagnitude;
    public CameraShake cameraShake;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float timeBetweenShots = 0.5f; // Adjust this value for the delay between shots
    public int currentClip, maxClipSize, currentAmmo;
    private float timer;
    private float timerReload;   
    public float reloadTime;
    

    void Start()
    {
        isshootingbool = false;

    }
    void Update()
    {
        animator.SetBool("IsReloading", reloadingBoolean);
        animator.SetBool("IsShooting", isshootingbool);
        // Increment the timer by the time passed since the last frame
        timer += Time.deltaTime;
        timerReload += Time.deltaTime;
        

        // Check if enough time has passed since the last shot
        if (timer >= timeBetweenShots && Input.GetButtonDown("Fire1") && currentClip>0 && reloadingBoolean == false )
        {
            Shoot();
            StartCoroutine(cameraShake.Shake(shakingDuration,shakingMagnitude));
            Invoke("BulletShell",.25f);
            timer = 0f; // Reset the timer after shooting
            currentClip--;
        }

        if (Input.GetKey(KeyCode.R ))
        {
            
            if (timerReload > reloadTime && currentClip != maxClipSize)
            {   reloadingBoolean = true;
                audioSource.PlayOneShot(ReloadiongSound);
                Invoke("Reload", reloadTime);
                timerReload = 0f;
            }
        }
    }

    void Shoot()
    {
        isshootingbool = true;
        audioSource.PlayOneShot(ShootingSound);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        Invoke("timeofshootinganim",0.28f); 
        
    }

    public void Reload()
    {
        
        int reloadAmount = maxClipSize - currentClip;
        reloadAmount = (currentAmmo - reloadAmount) >= 0 ? reloadAmount : currentAmmo;
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
        reloadingBoolean = false;
        
    }

    public void BulletShell()
    {
        audioSource.PlayOneShot(BulletShellSound);
    }
    
    public void timeofshootinganim()
    {
       isshootingbool = false;



    } 


}
