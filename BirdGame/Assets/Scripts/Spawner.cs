using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _nextSpawn;
    [SerializeField] private GameObject _spawnObject;

    private float _countDowner;

    private void Start()
    {
        _countDowner = _nextSpawn - 1;
    }

    private void Update()
    {
        _countDowner += Time.deltaTime;

        if (_countDowner > _nextSpawn)
        {
            GameObject spawnObject = (GameObject)Instantiate(_spawnObject, transform.position, Quaternion.identity);
            Destroy(spawnObject, 1f);
            _countDowner = 0f;
        }
    }
}
