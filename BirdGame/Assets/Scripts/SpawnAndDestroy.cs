using UnityEngine;

public class SpawnAndDestroy : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _destroyPoint;

    private void Update()
    {
        if (transform.position.x <= _destroyPoint.position.x)
            transform.position = _spawnPoint.position;
    }
}
