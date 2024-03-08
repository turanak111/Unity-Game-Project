using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoTextCanvas : MonoBehaviour
{
    public Shooting shooting;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmoText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAmmoText();
    }

    public void UpdateAmmoText()
    {
        text.text = $"{shooting.currentClip} / {shooting.maxClipSize} | {shooting.currentAmmo}";
    }
}
