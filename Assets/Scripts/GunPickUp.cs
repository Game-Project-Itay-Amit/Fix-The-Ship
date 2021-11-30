using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    [Tooltip("Represents the gun the player is holding")]
    [SerializeField] GameObject PlayerGun;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);
            PlayerGun.SetActive(true);
        }
    }
    void Update()
    {
        
    }
}
