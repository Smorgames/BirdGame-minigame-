using TMPro;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    protected int _health;
    protected TextMeshProUGUI _healthText;

    public HealthSystem(int health, TextMeshProUGUI healthText)
    {
        _health = health;
        _healthText = healthText;
    }

    public int GetHealth()
    {
        return _health;
    }

    public void SetStartHealth(int health)
    {
        _health = health;
        _healthText.text = _health.ToString();
    }

    public virtual void Damage(int damage, GameObject objectToDestroy)
    {
        _health -= damage;

        if (_health <= 0)
            _health = 0;

        _healthText.text = _health.ToString();

        if (_health <= 0)
            Death(objectToDestroy);
    }

    private void Death(GameObject objectToDestroy)
    {
        Destroy(objectToDestroy);
    }
}

public class PlayerHealthSystem : HealthSystem
{
    public PlayerHealthSystem(int health, TextMeshProUGUI healthText) : base(health, healthText) { }

    public override void Damage(int damage, GameObject objectToDestroy)
    {
        _health -= damage;

        if (_health <= 0)
            _health = 0;

        _healthText.text = _health.ToString();

        if (_health <= 0)
            GAME_MANAGER.instance.GameOver();
    }
}