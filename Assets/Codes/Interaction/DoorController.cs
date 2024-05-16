using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator;

    public GameObject player;
    public Collider2D doorCollider;

    public float distance;
    private bool isDoorOpen = false;

    void Update()
    {
        // E tuşuna basıldığında kapıyı aç veya kapat
        if (Vector2.Distance(transform.position, player.transform.position) < distance && Input.GetKeyDown(KeyCode.E))
        {
            if (!isDoorOpen)
            {
                OpenDoor();
            }
            else
            {
                CloseDoor();
            }
        }
    }

    void OpenDoor()
    {
        // Kapıyı açma animasyonunu başlat
        doorAnimator.SetTrigger("Open");
        
        // Collider'ı devre dışı bırak
        //doorCollider.enabled = false;

        isDoorOpen = true;
    }

    void CloseDoor()
    {
        // Kapıyı kapatma animasyonunu başlat
        doorAnimator.SetTrigger("Close");

        // Collider'ı etkinleştir
        //doorCollider.enabled = true;

        isDoorOpen = false;
    }
}
