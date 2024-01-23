using UnityEngine;
/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyAfterHits : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] int HitPoints;
    [Tooltip("Every enemy hitting will decrease this field")]
    [SerializeField] NumberField HealthField;
    private void Start()
    {
        HealthField.SetNumber(HitPoints);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            --HitPoints;
            HealthField.SetNumber(HitPoints);
            if (HitPoints == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}