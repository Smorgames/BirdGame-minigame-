using UnityEngine;
using TMPro;

public class Box : MonoBehaviour
{
    private HealthSystem _healthSystem;

    [SerializeField] private int _health;
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Start()
    {
        _healthSystem = new HealthSystem(_health, _healthText);
        _healthSystem.SetStartHealth(Random.Range(_health / _health, _health + 1)); // set health = random int number between 1 and 3
    }

    public void Damage(int damage)
    {
        _healthSystem.Damage(damage, gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>() != null)
        {
            collision.GetComponent<PlayerHealth>().Damage(_healthSystem.GetHealth());
            Destroy(gameObject);
        }
    }
}
