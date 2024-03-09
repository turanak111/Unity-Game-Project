using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollidableObject
{
    private bool z_Interacted = false;
   protected override void OnCollided(GameObject collidedObject)
    {
     if (collidedObject.layer == LayerMask.NameToLayer("Player"))
     {   
        if(Input.GetKey(KeyCode.Space))
        {
            OnInteract();

        }
    }
    }
    protected virtual void OnInteract()
    {
        if(!z_Interacted)
        {
            z_Interacted = true;
            Debug.Log("Interact with" + name);

        }

    }
}
