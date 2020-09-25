using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject _boxPrefab;
    [SerializeField] private GameObject _artifactPrefab;

    [SerializeField] private SpawnObjectType _type;

    [SerializeField] private float _objectsDestroyTime;

    private void OnEnable()
    {
        if (_type == SpawnObjectType.Box)
        {
            GameObject spawnObject = (GameObject)Instantiate(_boxPrefab, transform.position, Quaternion.identity);
            Destroy(spawnObject, _objectsDestroyTime);
        }

        if (_type == SpawnObjectType.Artifact)
        {
            GameObject spawnObject = (GameObject)Instantiate(_artifactPrefab, transform.position, Quaternion.identity);
            Destroy(spawnObject, _objectsDestroyTime);
        }
    }
}

enum SpawnObjectType
{
    Artifact,
    Box
}