using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the spawning of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject WallSpawn;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            // WallSpawn.
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
