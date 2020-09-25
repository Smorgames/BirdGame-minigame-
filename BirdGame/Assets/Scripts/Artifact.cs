using UnityEngine;

public class Artifact : MonoBehaviour
{
    [SerializeField] private int _pointAmount;
    [SerializeField] private GameObject _pickEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
        {
            GAME_MANAGER.instance.AddPoint(_pointAmount);

            GameObject pickEffect = (GameObject)Instantiate(_pickEffect, transform.position, Quaternion.identity);
            Destroy(pickEffect, 2f);

            Destroy(gameObject);
        }
    }
}
