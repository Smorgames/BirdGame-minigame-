using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damageAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Box>() != null)
        {
            collision.GetComponent<Box>().Damage(_damageAmount);
            Destroy(gameObject);
        }
    }
}
