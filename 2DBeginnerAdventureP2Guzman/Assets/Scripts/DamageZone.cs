using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
     void OnTriggerStay2D(Collider2D other)
    {
        MarshmallowController controller = other.GetComponent<MarshmallowController>();

        if(controller != null )
        {
            controller.ChangeHealth(-1);
        }
    }


}
