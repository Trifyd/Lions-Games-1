using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cible_mourir : MonoBehaviour
{
    public LayerMask bullet;
    private void OnTriggerEnter(Collider bullet)
    {
        Destroy(bullet,0f);
        Destroy(this,0f);
    }
}
