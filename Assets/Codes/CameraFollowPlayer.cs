using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    GameObject player;
    bool followPlayer = true;
    float minDistance = 0f;
    float maxDistance = 3f;
    float smoothSpeed = 1f;
    Vector3 cursorPosition;
    Vector3 velocity = Vector3.zero;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
        cursorPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        if (followPlayer)
        {
            FollowPlayerWithCursor();
        }
    }

    public void SetFollowPlayer(bool val)
    {
        followPlayer = val;
    }

  void FollowPlayerWithCursor()
{
    
    float distance = Vector3.Distance(player.transform.position, cursorPosition);
    float clampedDistance = Mathf.Clamp(distance, minDistance, maxDistance);
    Vector3 targetPosition = player.transform.position + (cursorPosition - player.transform.position).normalized * clampedDistance;

    Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed * Time.deltaTime);
    smoothedPosition.z = -10f;
    transform.position = smoothedPosition;
}
}
