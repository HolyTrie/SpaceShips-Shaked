using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class BuffTrigger : MonoBehaviour {
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject BuffPrefab;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);
                Instantiate(BuffPrefab, other.transform);
        }
    }
}
