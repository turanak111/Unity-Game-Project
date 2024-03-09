using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 originalPos; // Store the original position of the camera
    private Vector3 shakeOffset; // Store the current offset due to shaking

    public IEnumerator Shake(float duration, float magnitude)
    {
        originalPos = transform.localPosition; // Store the original position
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            // Calculate random offset within magnitude
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            // Update shake offset
            shakeOffset = new Vector3(x, y, originalPos.z);

            // Apply shake offset to the camera's position
            transform.localPosition = originalPos + shakeOffset;

            elapsed += Time.deltaTime;

            yield return null;
        }

    
        // Reset camera position to original position after shake
        transform.localPosition = originalPos;
    }
}
