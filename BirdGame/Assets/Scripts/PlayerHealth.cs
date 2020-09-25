using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    private PlayerHealthSystem _healthSystem;

    [SerializeField] private int _health;
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Awake()
    {
        instance = this;
        _healthSystem = new PlayerHealthSystem(_health, _healthText);
    }

    private void Start()
    {
        _healthSystem.SetStartHealth(_health);
    }

    public void Damage(int damage)
    {
        _healthSystem.Damage(damage, gameObject);
    }
}
