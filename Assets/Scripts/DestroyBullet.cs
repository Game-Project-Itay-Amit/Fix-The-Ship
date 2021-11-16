using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBullet : MonoBehaviour
{
    // private Rigidbody rb;
    // private TouchDetector td;
    // void Start() {
    //     rb = GetComponent<Rigidbody>();
    //     td = GetComponent<TouchDetector>();
    // }
    // /*
    //  * Note that updates related to the physics engine should be done in FixedUpdate and not in Update!
    //  */
    // private void FixedUpdate() {
    //     if (td.IsTouching()) {  // allow to walk and jump 
    //         Destroy(this.gameObject);    
    //     }
    // }
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            // Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
