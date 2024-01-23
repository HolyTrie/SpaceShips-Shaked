using UnityEngine;
/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [SerializeField] string[] triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        for(int i = 0; i<triggeringTag.Length; ++ i)
            if (other.tag == triggeringTag[i] && enabled)
                Destroy(this.gameObject);
    }
}