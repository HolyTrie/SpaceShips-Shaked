using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    [SerializeField] int HitPoints;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
            --HitPoints;
            Debug.Log("Your Health is : " + HitPoints);
            if(HitPoints == 0)
            {
                Debug.Log("You are dead!");
                Destroy(this.gameObject);
            }
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
