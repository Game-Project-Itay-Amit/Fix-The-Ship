using UnityEngine;

public class Collectible : MonoBehaviour{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTagTrue, triggeringTagFalse;
    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("hit: "+ this.tag);
        isFixed player = other.GetComponent<isFixed>();
        if (this.tag == triggeringTagTrue && enabled) {
            player.TrueAns();
            Debug.Log("true ans");
            // Destroy(gameObject);
        }
        else if(this.tag == triggeringTagFalse && enabled) {
            player.FalseAns();
            Debug.Log("false ans");
            // Destroy(gameObject);
        }
    }
}
